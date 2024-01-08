using AutoMapper;
using Wallet.API.Models.Dto;

namespace Wallet.API.Mappings;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Models.Domain.Wallet, AddWalletDto>().ReverseMap();
        CreateMap<Models.Domain.Wallet, WalletResponseDto>().ReverseMap();
    }
}