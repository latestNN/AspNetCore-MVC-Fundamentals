# ASP.NET Core MVC Öğrenme Rehberi ve Notları

Bu repository, ASP.NET Core MVC öğrenim sürecimde adım adım aldığım ders notlarını ve geliştirdiğim pratik projeleri içermektedir. Hem konuların teorik altyapısını hem de kod üzerindeki pratik uygulamalarını düzenli bir hiyerarşi ile bir araya getirmeyi amaçlıyor.

## 📚 Konu Fihristi ve Ders Materyalleri

| Konu Adı | Alt Başlıklar ve Açıklamalar | Kodlar | Notlar |
| :--- | :--- | :--- | :--- |
| **Temel Web** | <sub>- İstemci, Sunucu, Request ve Response Süreçleri<br>- Domain Kavramı ve Yönlendirme<br>- Web Uygulamaları İçin Frontend ve Backend Teknolojileri</sub> | - | [📄 PDF](Notes/Temel_Web.pdf) |
| **Web Geliştirme Yaklaşımları** | <sub>- Web Uygulamaları, API İletişimi<br>- İstemci-Sunucu Kavramları</sub> | - | [📄 PDF](Notes/Web_Gelistirme_Yaklasimlari.pdf) |
| **Server Türleri** | <sub>- IIS ve Kestrel (Dahili Web Sunucusu)<br>- Linux İçin Nginx ve Apache Sunucuları<br>- Docker Sanallaştırması ve Windows İçin HTTP.sys</sub> | - | [📄 PDF](Notes/Server_Turleri.pdf) |
| **HTTP Protokolleri** | <sub>- İstemci ve Sunucu Haberleşmesi<br>- GET (Select) ve POST (Insert) İstekleri<br>- PUT/PATCH (Güncelleme) ve DELETE (Silme) İşlemleri</sub> | - | [📄 PDF](Notes/HTTP_Protokolleri.pdf) |
| **Asp.Net Genel Bilgiler** | <sub>- Controller ve Action İşleyişi<br>- HttpGet ve HttpPost Attribute'ları<br>- Client-Side-Library ile Frontend Kütüphaneleri (wwwroot)<br>- Program.cs, Middleware'ler ve Klasör Yapısı</sub> | - | [📄 PDF](Notes/AspNet_Genel_Bilgiler.pdf) |
| **Sıfırdan MVC Proje Oluşturma** | <sub>- Program.cs İçerisinde Route Şeması Belirleme<br>- Controller Kalıtımı ve Action Metotları<br>- View Klasör Hiyerarşisi (.cshtml) ve Razor İşleyişi</sub> | - | [📄 PDF](Notes/Sifirdan_MVC_Proje_Olusturma.pdf) |
| **MVC Yapısı** | <sub>- Mimarisel Desen ve Tasarım Deseni Farkı<br>- Model, View ve Controller Katmanlarının Görevleri<br>- Pipeline İşleyiş Katmanları (Init, Execution, Rendering vb.)</sub> | - | [📄 PDF](Notes/MVC_Yapisi.pdf) |
| **View** | <sub>- View Nedir ve .cshtml Mantığı<br>- Razor Syntax Temelleri (@ Operatörü, Scope)<br>- View'a Model Bazlı Veri Taşıma<br>- ViewBag ile Dinamik Türde Veri Taşıma</sub> | [📂 Klasöre Git](P02_Viewler) | [📄 PDF](Notes/View.pdf) |
| **Action Türleri** | <sub>- Action Result Temel Sınıfı ve Mantığı<br>- ViewResult, PartialViewResult ve JsonResult<br>- EmptyResult, ContentResult ve ViewComponentResult<br>- [NonAction] ve [NonController] Özellikleri</sub> | - | [📄 PDF](Notes/Action_Turleri.pdf) |
| **Html Helpers** | <sub>- Url Metotları (Action, ActionLink, RouteUrl, Content)<br>- Html.Partial ve Html.RenderPartial<br>- Html Form Metotları ve Tag Helper Tercihi<br>- Custom Html Helpers</sub> | - | [📄 PDF](Notes/Html_Helpers.pdf) |
| **Model Binding Mekanizması** | <sub>- Model Binding Nedir ve Nasıl Çalışır?<br>- Client'dan Gelen Verinin Sınıflara (Entity) Dönüştürülmesi<br>- İki Taraflı Veri Bağlama ve Get/Post Davranışları</sub> | [📂 Klasöre Git](P04_ModelBinding) | [📄 PDF](Notes/Model_Binding_Mekanizmasi.pdf) |
| **Kullanıcıdan Veri Alma** | <sub>- Request.QueryString ile URL'den Veri Alma<br>- Route Parametreleri Üzerinden Veri Taşıma<br>- Custom Route Parametreleri Tanımlama ve Yakalama</sub> | [📂 Klasöre Git](P05_Kullanicidan-Veri-Alma) | [📄 PDF](Notes/Kullanicidan_Veri_Alma_Yontemleri.pdf) |
| **Validation (Validasyon)** | <sub>- Server Side Validation (Required, StringLength vb.)<br>- ModelState ile Veri Doğrulama ve Hata Gösterme<br>- Fluent Validation Kurulumu ve AbstractValidator Sınıfı</sub> | - | [📄 PDF](Notes/Validation.pdf) |
| **Layout, _ViewStart ve _ViewImports** | <sub>- Layout Mimarisi, Avantajları ve Oluşturulması<br>- @RenderBody() ve @RenderSection() Fonksiyonları<br>- _ViewStart.cshtml ile Ortak Layout Tanımlama<br>- _ViewImports.cshtml ile Kütüphane İçe Aktarma</sub> | [📂 Klasöre Git](P06_Layout) | [📄 PDF](Notes/Layout_ViewStart_ViewImports.pdf) |
| **Modüler Tasarım Yapılanması** | <sub>- Modüler Tasarım Mantığı ve Yönetilebilirlik<br>- Partial View: Oluşturma ve Veri Gönderme<br>- View Component: Kendi Backend'ine Sahip Modüller<br>- View Component'a Veri Gönderme ve [NonViewComponent]</sub> | [📂 Klasöre Git](P07_Moduler-Tasarim-Yapilanmasi) | [📄 PDF](Notes/Moduler_Tasarim_Yapilanmasi.pdf) |
| **Route Yapılanması** | <sub>- Routing Mantığı, app.UseRouting ve MapDefaultControllerRoute<br>- MapControllerRoute ile Custom Route<br>- Route Constraints (Tip ve Yapısal Kısıtlamalar)<br>- Attribute Routing ve Custom Route Handler</sub> | [📂 Klasöre Git](P08_Route-Yapilanmasi) | [📄 PDF](Notes/Route_Yapilanmasi.pdf) |
| **Middleware Mimarisi** | <sub>- Pipeline ve Request/Response Yaşam Döngüsü<br>- Hazır ve Custom Middleware Yazımı</sub> | 1. [📂 Türler](P09_Middleware/P09.01_Middleware-Turleri)<br>2. [📂 Custom](P09_Middleware/P09.02_Custom-Middleware) | [📄 PDF](Notes/Middleware.pdf) |
| **Dependency Injection** | <sub>- DI Tasarım Deseni, Amacı ve IoC Container<br>- Action Bazlı Servis Talebi ([FromServices])<br>- View İçerisinde Servis Talebi (@inject)</sub> | [📂 Klasöre Git](P10_Dependency-Injection) | [📄 PDF](Notes/Dependency_Injection.pdf) |
| **Areas** | <sub>- Area Kavramı ve Kullanım Alanları (Yönetim paneli vb.)<br>- Area Oluşturma ve Area Attribute'u<br>- MapAreaControllerRoute ile Özel Route<br>- Area'lar Arası Bağlantı Oluşturma</sub> | [📂 Klasöre Git](P11_Areas) | [📄 PDF](Notes/Areas.pdf) |
| **ViewModel** | <sub>- ViewModel Kullanım Senaryoları<br>- DTO ve ViewModel Arasındaki Farklar<br>- ViewModel Üzerinden Validation<br>- ViewModel'ı Entity'ye Dönüştürme Yöntemleri</sub> | [📂 Klasöre Git](P12_ViewModel-DTO) | [📄 PDF](Notes/ViewModel.pdf) |
| **Diğer Yapılandırmalar** | <sub>- appsettings.json Dosyası Kullanımı<br>- Secret Manager Tools Kullanımı<br>- Environment (Development, Staging, Production) Yönetimi</sub> | [📂 P13](P13_appsettings.json-Dosyasi)<br>[📂 P14](P14_Secret-Manager-Tools)<br>[📂 P15](P15_Environment) | - |

