# STARMN E-Commerce Proje Açıklaması

## Proje Tanımı

STARMN E-Commerce projesi, yalnızca monitör satışı üzerine geliştirilmiş bir e-ticaret uygulamasıdır. Projenin amacı; ürünlerin yönetilebildiği, kullanıcıların ürünleri inceleyebildiği ve temel alışveriş süreçlerinin gerçekleştirilebildiği bir web uygulaması geliştirmektir.

Proje geliştirme sürecinde katmanlı mimari yapısı kullanılmış ve yazılım geliştirme standartlarına uygun bir yapı oluşturulmuştur.

---

## Kullanılan Teknolojiler ve Mimari Yapı

Projede aşağıdaki teknolojiler kullanılmıştır:

* .NET Core 9
* Entity Framework Core
* Code First yaklaşımı
* SQL Server
* N-Tier Architecture (Katmanlı Mimari)
* Repository Pattern
* Dependency Injection
* JavaScript / AJAX

Uygulama;

* STARMN.Web
* STARMN.Service
* STARMN.Core
* STARMN.Database

katmanlarından oluşmaktadır.

Katmanlar arasındaki bağımlılıkların azaltılması amacıyla Dependency Injection yapısı kullanılmıştır.

---

## Veritabanı Yapısı

Veritabanı Entity Framework Core Code First yaklaşımı ile oluşturulmuştur.

Sistemde aşağıdaki tablolar bulunmaktadır:

* User
* Role
* Product
* Category
* Basket
* Order
* OrderDetail

Bu tablolar için gerekli entity ve ilişkisel yapılandırmalar oluşturulmuştur.

---

## Admin Panel İşlemleri

Admin panel tarafında sistem verilerinin yönetilebilmesi için CRUD işlemleri geliştirilmiştir.

Aşağıdaki tablolar için:

* Product
* Category
* User
* Role
* Order
* OrderDetail
* Basket

işlemleri yapılabilmektedir:

* Ekleme (Create)
* Listeleme (Read)
* Güncelleme (Update)
* Silme (Delete)

---

## Web Arayüzü İşlemleri

Kullanıcı tarafında monitör ürünlerinin görüntülenebilmesi için ürün listeleme ekranları hazırlanmıştır.

Gerçekleştirilen işlemler:

* Ürün listeleme
* Sepete ürün ekleme(Anasayfanın en alt kısmında olan Beststeller Product Kısmı için dinamik veri ve sepete ekleme)

Sepete ekleme işlemi JavaScript ve AJAX kullanılarak hazırlanmıştır.

Sepet işlemi anasayfanın alt kısmında bulunan ürün alanı üzerinden çalışmaktadır.

---

## Sonuç

STARMN E-Commerce projesi ile temel e-ticaret ihtiyaçlarını karşılayan bir sistem geliştirilmiştir. Proje içerisinde ürün, kategori, kullanıcı, rol, sipariş ve sepet yönetimi için gerekli altyapılar oluşturulmuş; katmanlı mimari prensiplerine uygun, geliştirilebilir bir yapı hazırlanmıştır.
