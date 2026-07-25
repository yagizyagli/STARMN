

using STARMN.Core.EntityDTOS;

namespace STARMN.Service.Services.Interfaces;

public interface IBasketService
{
    public SepetDto SepeteEkle(SepetDto sepetDto);
    public List<SepetDto> SepetList(int userId);

    public SepetDto SepeteIDIleGetir(int sepetId);
    public SepetDto SepetGuncelle(SepetDto sepetDto);

    bool SepetSil(int sepetId);
}
