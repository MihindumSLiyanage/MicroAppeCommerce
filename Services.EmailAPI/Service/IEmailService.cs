using Services.EmailAPI.Models.Dto;

namespace Services.EmailAPI.Service
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
    }
}
