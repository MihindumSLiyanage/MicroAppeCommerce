using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.OrderAPI.Data;
using Services.OrderAPI.Models;
using Services.OrderAPI.Models.Dto;
using Services.OrderAPI.Service.IService;
using Services.OrderAPI.Utility;

namespace Services.OrderAPI.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        protected ResponseDto _response;
        private IMapper _mapper;
        private readonly AppDbContext _dbContext;
        private IProductService _productService;
        private readonly IConfiguration _configuration;

        public OrderController(AppDbContext dbContext, IProductService productService, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            this._response = new ResponseDto();
            _productService = productService;
            _mapper = mapper;
            _configuration = configuration;
        }

        [Authorize]
        [HttpGet("GetOrders")]
        public ResponseDto? Get(string? userId = "")
        {
            try
            {
                IEnumerable<OrderHeader> objList;
                if (User.IsInRole(SD.RoleAdmin))
                {
                    objList = _dbContext.OrderHeaders.Include(u => u.OrderDetails).OrderByDescending(u => u.OrderHeaderId).ToList();
                }
                else
                {
                    objList = _dbContext.OrderHeaders.Include(u => u.OrderDetails).Where(u => u.UserId == userId).OrderByDescending(u => u.OrderHeaderId).ToList();
                }
                _response.Result = _mapper.Map<IEnumerable<OrderHeaderDto>>(objList);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [Authorize]
        [HttpGet("GetOrder/{id:int}")]
        public ResponseDto? Get(int id)
        {
            try
            {
                OrderHeader orderHeader = _dbContext.OrderHeaders.Include(u => u.OrderDetails).First(u => u.OrderHeaderId == id);
                _response.Result = _mapper.Map<OrderHeaderDto>(orderHeader);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [Authorize]
        [HttpPost("CreateOrder")]
        public async Task<ResponseDto> CreateOrder([FromBody] CartDto cartDto)
        {
            try
            {
                OrderHeaderDto orderHeaderDto = _mapper.Map<OrderHeaderDto>(cartDto.CartHeader);
                orderHeaderDto.OrderTime = DateTime.Now;
                orderHeaderDto.Status = SD.Status_Pending;
                orderHeaderDto.OrderDetails = _mapper.Map<IEnumerable<OrderDetailsDto>>(cartDto.CartDetails);
                orderHeaderDto.OrderTotal = Math.Round(orderHeaderDto.OrderTotal, 2);
                OrderHeader orderCreated = _dbContext.OrderHeaders.Add(_mapper.Map<OrderHeader>(orderHeaderDto)).Entity;
                await _dbContext.SaveChangesAsync();

                orderHeaderDto.OrderHeaderId = orderCreated.OrderHeaderId;
                _response.Result = orderHeaderDto;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
