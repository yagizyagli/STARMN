
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

            var varmiUrunSepette = _basketRepository.GetAll().FirstOrDefault(x => x.ProductId == sepetDto.ProductId && x.UserId == sepetDto.EkleynId);
            

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
                var getirUrun = _basketRepository.GetById(varmiUrunSepette.Id);

                getirUrun.UnitCount += 1;
                _basketRepository.Update(getirUrun);

                return sepetDto;
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
                Id=sepet.Id,
                EkleynId = sepet.UserId,
                ProductId = sepet.ProductId,
                Adet = sepet.UnitCount,
                Fiyat = sepet.Price,                
                
            };
        }

        public SepetDto SepetGuncelle(SepetDto sepetDto)
        {
            try
            {
                var sepet = _basketRepository.GetById(sepetDto.Id);
                if (sepet == null)
                {
                    return null;
                }
                sepet.UnitCount = sepetDto.Adet;
                sepet.Price = sepetDto.Fiyat;
                sepet.AddedDate = DateTime.Now;
                sepet.ProductId = sepetDto.ProductId;
                sepet.UserId = sepetDto.EkleynId;
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
            var cevirDto = list.Select(item =>
            {
                var product = _productRepository.GetById(item.ProductId);

                return new SepetDto
                {
                    Id = item.Id,
                    ProductId = item.ProductId,
                    Adi = product.Adi,
                    Adet = item.UnitCount,
                    Fiyat = item.Price,
                    EklenmeTarihi = item.AddedDate,
                    EkleynId = item.UserId,
                    Toplam = item.Price * item.UnitCount,

                };
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
