# ASP.NET Core MVC Öğrenme Rehberi ve Notları

Bu repository, ASP.NET Core MVC öğrenim sürecimde adım adım aldığım ders notlarını ve geliştirdiğim pratik projeleri içermektedir. Hem konuların teorik altyapısını hem de kod üzerindeki pratik uygulamalarını düzenli bir hiyerarşi ile bir araya getirmeyi amaçlıyor.

## 📚 Konu Fihristi ve Ders Materyalleri

| Konu Adı ve Alt Başlıklar | Kodlar | Notlar |
| :--- | :--- | :--- |
| **Temel Web** <br> <sub>- İstemci, Sunucu, Request ve Response Süreçleri<br>- Domain Kavramı ve Yönlendirme<br>- Web Uygulamaları İçin Frontend ve Backend Teknolojileri</sub> | - | [📄 PDF Oku](<Notes/Temel Web.pdf>) |
| **Web Geliştirme Yaklaşımları** <br> <sub>- Web Uygulamaları, API İletişimi<br>- İstemci-Sunucu Kavramları</sub> | - | [📄 PDF Oku](<Notes/Web Geliştirme Yaklaşımları.pdf>) |
| **Server Türleri** <br> <sub>- IIS ve Kestrel (Dahili Web Sunucusu)<br>- Linux İçin Nginx ve Apache Sunucuları<br>- Docker Sanallaştırması ve Windows İçin HTTP.sys</sub> | - | [📄 PDF Oku](<Notes/Server Türleri.pdf>) |
| **HTTP Protokolleri** <br> <sub>- İstemci ve Sunucu Haberleşmesi<br>- GET (Select) ve POST (Insert) İstekleri<br>- PUT/PATCH (Güncelleme) ve DELETE (Silme) İşlemleri</sub> | - | [📄 PDF Oku](<Notes/HTTP Protokolleri.pdf>) |
| **Asp.Net Genel Bilgiler** <br> <sub>- Controller ve Action İşleyişi<br>- HttpGet ve HttpPost Attribute'ları<br>- Client-Side-Library ile Frontend Kütüphaneleri (wwwroot)<br>- Program.cs, Middleware'ler ve Klasör Yapısı</sub> | - | [📄 PDF Oku](<Notes/Asp.Net Genel bilgiler.pdf>) |
| **Sıfırdan MVC Proje Oluşturma** <br> <sub>- Program.cs İçerisinde Route Şeması Belirleme<br>- Controller Kalıtımı ve Action Metotları<br>- View Klasör Hiyerarşisi (.cshtml) ve Razor İşleyişi</sub> | - | [📄 PDF Oku](<Notes/Sıfırdan MVC Proje oluşturma.pdf>) |
| **MVC Yapısı** <br> <sub>- Mimarisel Desen ve Tasarım Deseni Farkı<br>- Model, View ve Controller Katmanlarının Görevleri<br>- Pipeline İşleyiş Katmanları (Init, Execution, Rendering vb.)</sub> | - | [📄 PDF Oku](<Notes/MVC Yapısı.pdf>) |
| **View** <br> <sub>- View Nedir ve .cshtml Mantığı<br>- Razor Syntax Temelleri (@ Operatörü, Scope)<br>- View'a Model Bazlı Veri Taşıma<br>- ViewBag ile Dinamik Türde Veri Taşıma</sub> | [📂 Klasöre Git](P02_Viewler) | [📄 PDF Oku](<Notes/View.pdf>) |
| **Action Türleri** <br> <sub>- Action Result Temel Sınıfı ve Mantığı<br>- ViewResult, PartialViewResult ve JsonResult<br>- EmptyResult, ContentResult ve ViewComponentResult<br>- [NonAction] ve [NonController] Özellikleri</sub> | - | [📄 PDF Oku](<Notes/Action Türleri.pdf>) |
| **Html Helpers** <br> <sub>- Url Metotları (Action, ActionLink, RouteUrl, Content)<br>- Html.Partial ve Html.RenderPartial<br>- Html Form Metotları ve Tag Helper Tercihi<br>- Custom Html Helpers</sub> | - | [📄 PDF Oku](<Notes/Html Helpers.pdf>) |
| **Model Binding Mekanizması** <br> <sub>- Model Binding Nedir ve Nasıl Çalışır?<br>- Client'dan Gelen Verinin Sınıflara (Entity) Dönüştürülmesi<br>- İki Taraflı Veri Bağlama ve Get/Post Davranışları</sub> | [📂 Klasöre Git](P04_ModelBinding) | [📄 PDF Oku](<Notes/Model Binding Mekanizması.pdf>) |
| **Kullanıcıdan Veri Alma** <br> <sub>- Request.QueryString ile URL'den Veri Alma<br>- Route Parametreleri Üzerinden Veri Taşıma<br>- Tuple Nesne Yakalama</sub> | 1. [📂 Form](P05.01_Form-ile-Veri-Alma)<br>2. [📂 QueryString](P05.02_QueryString-Uzerinden-Veri-Alma)<br>3. [📂 Route Param](P05.03_Route-Paramaetreleri-ile-Veri-Alma)<br>4. [📂 Tuple](P05.03_Tuple-Nesne-Post-Yakalma-Islemleri) | 1. [📄 Yöntemler](<Notes/Kullanıcıdan Veri Alma Yöntemleri.pdf>)<br>2. [📄 Tuple](<Notes/Tuple Nesne ile Binding.pdf>) |
| **Validation (Validasyon)** <br> <sub>- Server Side Validation (Required, StringLength vb.)<br>- ModelState ile Veri Doğrulama ve Hata Gösterme<br>- Fluent Validation Kurulumu ve AbstractValidator Sınıfı</sub> | 1. [📂 Validation](P05.01_Validation)<br>2. [📂 Modüler](P05.02_Validationlari-Baska-Sinifta-Tutma-Moduler)<br>3. [📂 Fluent](P05.03_Fluent-Validation)<br>4. [📂 Server-Client](P05.04_Server_Validationlari_Cilent_Tabanli_Uygulamalar) | [📄 PDF Oku](<Notes/Validation.pdf>) |
| **Layout, _ViewStart ve _ViewImports** <br> <sub>- Layout Mimarisi, Avantajları ve Oluşturulması<br>- @RenderBody() ve @RenderSection() Fonksiyonları<br>- _ViewStart.cshtml ile Ortak Layout Tanımlama<br>- _ViewImports.cshtml ile Kütüphane İçe Aktarma</sub> | [📂 Klasöre Git](P06_Layout) | [📄 PDF Oku](<Notes/Layout - _ViewStart - _ViewImports.pdf>) |
| **Modüler Tasarım Yapılanması** <br> <sub>- Modüler Tasarım Mantığı ve Yönetilebilirlik<br>- Partial View: Oluşturma ve Veri Gönderme<br>- View Component: Kendi Backend'ine Sahip Modüller<br>- View Component'a Veri Gönderme ve [NonViewComponent]</sub> | [📂 Klasöre Git](P07_Moduler-Tasarim-Yapilanmasi) | [📄 PDF Oku](<Notes/Modüler Tasarım Yapılanması (PartialView - ViewComponent).pdf>) |
| **Route Yapılanması** <br> <sub>- Routing Mantığı, app.UseRouting ve MapDefaultControllerRoute<br>- MapControllerRoute ile Custom Route<br>- Route Constraints (Tip ve Yapısal Kısıtlamalar)<br>- Attribute Routing ve Custom Route Handler</sub> | [📂 Klasöre Git](P08_Route-Yapilanmasi) | [📄 PDF Oku](<Notes/Route Yapılanması.pdf>) |
| **Middleware Mimarisi** <br> <sub>- Pipeline ve Request/Response Yaşam Döngüsü<br>- Hazır ve Custom Middleware Yazımı</sub> | 1. [📂 Türler](P09.01_Middleware-Turleri)<br>2. [📂 Custom](P09.02_Custom-Middleware) | [📄 PDF Oku](<Notes/Middleware.pdf>) |
| **Dependency Injection** <br> <sub>- DI Tasarım Deseni, Amacı ve IoC Container<br>- Action Bazlı Servis Talebi ([FromServices])<br>- View İçerisinde Servis Talebi (@inject)</sub> | [📂 Klasöre Git](P10_Dependency-Injection) | [📄 PDF Oku](<Notes/Dependency Injection.pdf>) |
| **Areas** <br> <sub>- Area Kavramı ve Kullanım Alanları (Yönetim paneli vb.)<br>- Area Oluşturma ve Area Attribute'u<br>- MapAreaControllerRoute ile Özel Route<br>- Area'lar Arası Bağlantı Oluşturma</sub> | [📂 Klasöre Git](P11_Areas) | [📄 PDF Oku](<Notes/Areas.pdf>) |
| **ViewModel** <br> <sub>- ViewModel Kullanım Senaryoları<br>- DTO ve ViewModel Arasındaki Farklar<br>- ViewModel Üzerinden Validation<br>- ViewModel'ı Entity'ye Dönüştürme Yöntemleri</sub> | [📂 Klasöre Git](P12_ViewModel-DTO) | [📄 PDF Oku](<Notes/ViewModel.pdf>) |
| **Diğer Yapılandırmalar** <br> <sub>- appsettings.json Dosyası Kullanımı<br>- Secret Manager Tools Kullanımı<br>- Environment (Development, Staging, Production) Yönetimi</sub> | [📂 P13](P13_appsettings.json-Dosyasi)<br>[📂 P14](P14_Secret-Manager-Tools)<br>[📂 P15](P15_Environment) | [📄 PDF Oku](<Notes/Environment.pdf>) |



1. Repoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/KULLANICI_ADIN/REPO_ADIN.git](https://github.com/KULLANICI_ADIN/REPO_ADIN.git)
