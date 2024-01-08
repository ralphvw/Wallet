using AutoMapper;
using WalletApp.API.Models.Domain;
using WalletApp.API.Models.Dto;

namespace WalletApp.API.Mappings;

public class AutoMapperProfiles: Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Wallet, AddWalletDto>().ReverseMap();
        CreateMap<Wallet, WalletResponseDto>().ReverseMap();
    }
}