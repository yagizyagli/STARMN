
using STARMN.Access.Repositories.Interfaces;
using STARMN.Core.EntityDTOS;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class BasketService : IBasketService
    {
        private readonly IProductRepository _productRepository;
        private readonly IBasketRepository _basketRepository;

        public BasketService(IProductRepository productRepository, IBasketRepository basketRepository)
        {
            _productRepository = productRepository;
            _basketRepository = basketRepository;
        }
        public SepetDto SepeteEkle(SepetDto sepetDto)
        {
            List<SepetDto> sepet = new List<SepetDto>();

            var varmiUrunSepette = sepet.Where(k => k.ProductId == sepetDto.ProductId).FirstOrDefault();

            if (varmiUrunSepette == null)
            {
                
                _basketRepository.Save(new Database.Entities.Basket
                {
                    ProductId = sepetDto.ProductId,
                    UnitCount = sepetDto.Adet,
                    AddedDate = DateTime.Now,
                    UserId = sepetDto.EkleynId,
                    Price = sepetDto.Fiyat,
                });
                return sepetDto;
            }
            else
            {
                var getirUrun = _basketRepository.GetById(varmiUrunSepette.ProductId);

                getirUrun.UnitCount += 1;
                _basketRepository.Update(getirUrun);

                return varmiUrunSepette;
            }

        }

        public SepetDto SepeteIDIleGetir(int sepetId)
        {
            var sepet = _basketRepository.GetById(sepetId);
            if (sepet == null) {
                return null;
            } 

            return new SepetDto
            {
                EkleynId = sepet.UserId,
                ProductId = sepet.ProductId,
                Adet = sepet.UnitCount,
                Fiyat = sepet.Price
            };
        }

        public SepetDto SepetGuncelle(SepetDto sepetDto)
        {
            try
            {
                var sepet = _basketRepository.GetById(sepetDto.ProductId);
                if (sepet == null)
                {
                    return null;
                }
                sepet.UnitCount = sepetDto.Adet;
                sepet.Price = sepetDto.Fiyat;
                sepet.AddedDate = DateTime.Now;
                _basketRepository.Update(sepet);
                return sepetDto;

            }
            catch
            {
                return null;
            }
        }

        public List<SepetDto> SepetList(int userId)
        {
            var list = _basketRepository.GetAll().Where(k => k.UserId == userId).ToList();

            var cevirDto = list.Select(item => new SepetDto
            {
                EkleynId = item.UserId,
                ProductId = item.ProductId,
                Adet = item.UnitCount,
                Fiyat = item.Price
            }).ToList();

            return cevirDto;
        }        

        public bool SepetSil(int sepetId)
        {
            try
            {
                 _basketRepository.Delete(sepetId);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
