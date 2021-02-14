using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        // bu sınıftan nesne olusturuldugunda bu sınıfa constructır parametresı olarak bır RentACarContext nesnesi atanmıs olacak. ılk olarak EfEntityRepositoryBase sınıfının constructorı
        //caglıacak bu sınıfın concstructı RentACarContext context degıskenını (bu degısken bu sınıftan nesne olusturulurken bu sınıfın constructır parametresı ıcın olusturulan RentACarContext nesnesinin referansını taşıyor.....)  ust sınıfın constructırına yolluyacak
        // cnku ust snıfın constructri generic bir Tcontex yani ust sınıfa sen RentACarContext inden olusturdugumuz nesneyı  kullanacan dıyoruz.
        //bu durumda bu sunuf ust snıfın metotlarını kullanırken ust sınıfını TContext i artık burdan yolladıgımız RentACarContext context degıskenınn ısaret ettıgı  RentACarContext nesnesi olacak.
        // Ayrıyeten bu sınıf ıcın ozellesmım bu sınıfta ımplemnt edılen metotları kullanmak ıcın dde
        // ust sınıftakı protected olarak tanımlanan, ve bu sınınıf constractırı ıle ust sınıfa gonderılen RentACarContext context,
        // parametresinin referansını tuttugu RentACarContext nesnesının ust sınıftakı constructırda ilk atamasını alan context alanı artık RentACarContext nesnesının referansını tutuyor oldugundan,
        // o protectet context alananını burada olusturulan RentAcarContex tipinde _context propertisine get yaparak alıyoruz.
        // bu durumda burada olusturulan _context alanı da artık, bu sınıftan nesne olusturuldugunda bu sınıfa constructır parametresı olarak olusturulan RentACarContext nesnesinin referansını tutuyor olacak.
        // sonuc olarak hem buradakı _context hemde us sınıfttaki protected tanımlanan context alanları aynı RentACarContext nesnesinin referansını tutuyor olacklar.BunlAR bir sınıfın(RentACarContext) nesnesinin refeansı tuttugu ıcın bu nesne uzerınden , sınıfın üyelerıne erısebılıyorlar artık. bu sınıf da entity framework DbContext sınıfından kalıtım aldıgından dolayı DBContexin yanı entıty frameworkun metotları artık _context ve context tarafından kullanılabılır durumda.

        // _context bu alanı propertıes olarak tanımlayıp ust sınıftakı protected olan context degıskenınden de get ile döndürebilirdik
        // cunku ust sınıftakı contexte burdakı constractır parametresı olan nesne atandı. 
        // bız oyle yapmak yerıne burdakı constractır parametresı olan nesneın referansını tutan context parametresını burdakı constrıctor ıcınde dırek atadık.
        private RentACarContext _context; /*{ get { return context as RentACarContext; } }*/
        
        public EfCarDal(RentACarContext context) : base(context)
        {
            _context = context;
        }
        

        public IEnumerable<CarDetailDto> GetCarDetails() 
        {
            
            
                var result = from c in _context.Cars
                             join b in _context.Brands
                             on c.BrandId equals b.Id
                             join cl in _context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto()
                             {
                                 Id = c.Id,
                                 BrandName=b.BrandName,
                                 ColorName=cl.ColorName,
                                 ModelYear=c.ModelYear,
                                 DailyPrice=c.DailyPrice,
                                 Descriptions=c.Descriptions
                             };
                return result.ToList();
            

        }
    }
}
