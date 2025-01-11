# QuickBites: Restoran Yönetim Sistemi 🍽️📱  

***QuickBites***, yemek deneyimini dijital ortamda en iyi şekilde sunmayı amaçlayan bir platformdur. Kullanıcılar, restoranın eşsiz menüsünü inceleyebilir, kolayca sipariş oluşturabilir ve yemek dünyasında keyifli bir yolculuğa çıkabilir 

#### PROJEDE KULLANILAN PROGRAMLAMA DİLLERİ, KÜTÜPHANELER VE TEKNOLOJİLER 💻🔧
<p>
  <img alt="C#" src="https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white&logoWidth=50" />
  <img alt="ASP.NET Core" src="https://img.shields.io/badge/ASP.NET%20Core-%231BA3E8.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="MVC" src="https://img.shields.io/badge/MVC-%23DD0031.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="N Katmanlı Mimari" src="https://img.shields.io/badge/N%20Katmanlı%20Mimari-%237D7D7D.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="SignalR" src="https://img.shields.io/badge/SignalR-%237D4698.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Entity Framework" src="https://img.shields.io/badge/Entity%20Framework-%2358B9C9.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="FluentValidation" src="https://img.shields.io/badge/FluentValidation-%23563D7C.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Identity" src="https://img.shields.io/badge/Identity-%233B5998.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="AutoMapper" src="https://img.shields.io/badge/AutoMapper-%23FF6F61.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Ajax" src="https://img.shields.io/badge/Ajax-%2300A9E0.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="MailKit" src="https://img.shields.io/badge/MailKit-%23FFCC33.svg?style=for-the-badge&logo=generic&logoColor=black" />
  <img alt="QrCode" src="https://img.shields.io/badge/QrCode-%23000000.svg?style=for-the-badge&logo=qrcode&logoColor=white" />
  <img alt="SMTP" src="https://img.shields.io/badge/SMTP-%23FFA500.svg?style=for-the-badge&logo=minutemailer&logoColor=black" />
  <img alt="RapidAPI" src="https://img.shields.io/badge/RapidAPI-%2300BFFF.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Jira" src="https://img.shields.io/badge/Jira-%230052CC.svg?style=for-the-badge&logo=jira&logoColor=white" />
  <img alt="MSSQL Server" src="https://img.shields.io/badge/MSSQL%20Server-%23FF4F4F.svg?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
</p>

#### 🎯 NASIL BİR PROJE OLUŞTURDUK?
Bu proje, restoranların dijital yönetimini sağlayan güçlü bir platformdur. **QuickBites**, restoran sahiplerinin menüleri, siparişleri ve müşteri taleplerini kolayca yönetebileceği bir ***admin paneli*** sunar. Sistem, restoran süreçlerini dijitalleştirerek verimliliği artırmayı ve restoran yönetimini daha verimli hale getirmeyi hedefler.

**QuickBites**, yemek severler için kolay kullanım ve hızlı erişim sağlayarak, restoranların dijital ortamda etkin bir şekilde yönetilmesine olanak tanır. Proje, kullanıcı dostu arayüzü ile restoran menüsüne hızlıca göz atmayı ve sipariş vermeyi kolaylaştırmayı hedefler.

### PROJE DETAYLARI 📝 ###

Projemiz, **ASP.NET Core** ve **MVC** teknolojilerini içeren modern bir web uygulamasıdır. Projede **MsSQL Server** veri tabanı kullanılmış olup, **Code First** yaklaşımı ile veri tabanı yapısı oluşturulmuştur. Veri tabanı işlemleri için **Entity Framework** kullanılmaktadır.

Projemizde **N katmanlı mimari** kullanılarak modüler bir yapı sağlanmıştır. Bu sayede, her bir katman birbirinden bağımsız şekilde geliştirilmiş ve projede sürdürülebilirlik sağlanmıştır.

Ayrıca, projemizde şu önemli kütüphaneler ve araçlar kullanılmıştır:
- **SignalR**: Gerçek zamanlı iletişim için kullanılarak, kullanıcılar arasındaki anlık bildirimleri ve etkileşimi sağlar.
- **FluentValidation**: Veri doğrulama süreçlerini yönetmek ve kullanıcı girişlerini doğrulamak için.
- **Identity**: Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için güvenli bir çözüm sağlamak amacıyla kullanılmıştır.
- **AutoMapper**: Verileri farklı katmanlar arasında kolayca ve doğru şekilde taşımak için kullanılmıştır.
- **MailKit**: E-posta gönderimi ve yönetimi için entegre edilmiştir.
- **SMTP**: E-posta iletimi için kullanılan protokoller arasında yer alır.
- **QR Code**: Kullanıcıların menüleri veya siparişlerini hızlıca erişebilmelerini sağlamak için QR kodları kullanılır.
- **Ajax**: Sayfa yenilemesi olmadan asenkron veri alışverişini gerçekleştirmek için kullanılmıştır.

Bu sayede, projemiz verimli, yönetilebilir ve güvenli bir yapıya sahiptir. Kullanıcı dostu arayüzü ve güçlü admin paneli sayesinde restoran süreçlerini dijital ortamda kolayca yönetmek mümkün hale gelmiştir.

<p> QuickBites'ta iki tip kullanıcı bulunmaktadır: </p>

➡️ **1- Admin/Yönetici**

- [x] **Kategoriler**: Menülerdeki kategorileri yönetebilir. Yeni kategori ekleyebilir, mevcut kategorileri düzenleyebilir veya silebilir.
- [x] **Ürünler**: Ürünleri yönetebilir. Yeni ürün ekleyebilir, mevcut ürünleri güncelleyebilir veya silebilir.
- [x] **Rezervasyonlar**: Yapılan rezervasyonları görüntüleyebilir ve yönetebilir.
- [x] **Hakkımızda**: Restoran hakkında bilgileri güncelleyebilir.
- [x] **İndirimler**: İndirim kampanyalarını yönetebilir.
- [x] **İletişim**: İletişim bilgilerini düzenleyebilir.
- [x] **Öne Çıkanlar**: Öne çıkan menü veya ürünleri belirleyebilir.
- [x] **Referanslar**: Restoranın referanslarını görüntüleyebilir ve düzenleyebilir.
- [x] **Sosyal Medya**: Restoranın sosyal medya hesap bilgilerini yönetebilir.
- [x] **İstatistikler**: Web sitesi istatistiklerini anlık olarak görüntüleyebilir.
- [x] **Masalar**: Restoranın masa düzenini yönetebilir.
- [x] **Masa Durumları**: Masaların durumunu anlık olarak görüntüleyebilir (boş/dolu).
- [x] **Mesajlar**: Gelen mesajları görüntüleyebilir.
- [x] **Bildirimler**: Sistemdeki bildirimleri yönetebilir.
- [x] **Anlık Durum Çubuğu**: Web sitesindeki istatistikleri anlıkları anlık olarak görüntüleyebilir.
- [x] **Ayarlar**: Restoranın genel ayarlarını güncelleyebilir.
- [x] **Mail İşlemleri**: Sistem üzerinden mail gönderme yapabilir.
- [x] **QR Kod Oluştur**: QR kodları oluşturabilir ve yönetebilir.

➡️ **2- Ziyaretçi**

- [x] **Menümüz**: Restoranın mevcut yemek menüsünü görüntüleyebilir.
- [x] **Rezervasyon Yap**: Restoran veya etkinlik için rezervasyon yapabilir.
- [x] **Leziz Tarifler**: Dünya mutfağındaki ünlü yemeklerin tariflerini görüntüleyebilir.
- [x] **Sepetim**: Seçtiği ürünleri sepetine ekleyebilir, sepetini görüntüleyebilir ve sipariş verebilir.
- [x] **Harita**: Sistemdeki harita üzerinden ilgili alanlar ve konumlar hakkında bilgi alabilir.
- [x] **İletişim Formu**: İletişim formu aracılığıyla geri bildirimde bulunabilir, öneri ve şikayetlerini iletebilir.

📌 ***Ziyaretçi Sayfası*** ve ***Admin Paneli*** olmak üzere 2 modülün birleştirildiği bu projede, ziyaretçilerin ve yöneticilerin farklı yetkilere sahip olduğu bir sistem oluşturulmuştur. Ziyaretçiler belirli sayfalara erişim sağlarken, admin paneli üzerinden yöneticiler içerik yönetimi, kullanıcı işlemleri ve sistem ayarları gibi işlemleri gerçekleştirebilir.</br>

🔎 Ziyaretçi sayfasında, ***Ana Sayfa, Menü, Leziz Tarifler, Rezervasyon Yap*** ve ***Sepetim*** gibi bölümler bulunmaktadır. Aşağıda, Ziyaretçi sayfasına ait ekran görüntüleri yer almaktadır: </br>

🌱 ***Ana Sayfa:*** </br>

<img src="https://github.com/user-attachments/assets/d1b17cc1-bb6b-4291-8289-ef905e7efa95" alt="image" width="700"> </br>

🌱 ***Menü:*** </br>

<img src="https://github.com/user-attachments/assets/8741d5cf-4cfd-476a-9345-63f3e388072e" alt="image" width="700"> </br>

🌱 ***Leziz Tarifler:*** </br>

<img src="https://github.com/user-attachments/assets/55630f02-465d-43f5-a37d-8a7ab7b9bfd1" alt="image" width="700"> </br>

🌱 ***Rezervasyon Yap:*** </br>

<img src="https://github.com/user-attachments/assets/a6eaa7d9-04c1-42ef-928b-8e9d6800d932" alt="image" width="700"> </br>

🌱 ***Sepetim:*** </br>

<img src="https://github.com/user-attachments/assets/d919c28d-4264-4790-9eed-3250ff1ff2e5" alt="image" width="700"> </br>

🔎 Admin Panelinde ***Kategoriler, Ürünler, Rezervasyonlar, Hakkımızda, İndirimler, İletişim, Öne Çıkanlar, Referanslar, Sosyal Medya, İstatistikler, Masalar, Masa Durumları, Mesajlar, Bildirimler, Anlık Durum Çubuğu, Ayarlar, Mail İşlemleri*** ve ***QR Kod Oluştur*** olmak üzere toplam 18 farklı yönetim modülü bulunmaktadır. Yöneticiler bu modüller üzerinden içerikleri listeleyebilir, silebilir, ekleyebilir ve güncelleyebilir. Aşağıda, Admin Paneline ait yönetim modüllerinin ekran görüntüleri yer almaktadır: </br>

🌱 ***Kategoriler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/1a2dfc9b-7316-4bc8-a724-4602bed7ea91" alt="image" width="700"> </br>

🌱 ***Ürünler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/77cc64b5-45c1-4838-ab14-2e185e30c546" alt="image" width="700"> </br>

🌱 ***Rezervasyonlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/e03b7e1a-2ac7-4c61-a94d-51a1fe7db6e2" alt="image" width="700"> </br>

🌱 ***Hakkımızda Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/c881f931-884a-4f58-904f-f4eb93c7a54e" alt="image" width="700"> </br>

🌱 ***İndirimler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/b5d25805-3039-4dcb-8aab-37bf8fb0d46d" alt="image" width="700"> </br>

🌱 ***İletişim Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/763d128f-897a-4040-aebc-812dd3623116" alt="image" width="700"> </br>

🌱 ***Öne Çıkanlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/71aa8d88-bac5-4126-99b7-ff4c40c965b8" alt="image" width="700"> </br>

🌱 ***Referanslar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/1bcbcf91-4524-414f-85cf-1e6d68ae5e09" alt="image" width="700"> </br>

🌱 ***Sosyal Medya Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/afef647c-11e4-4fd2-a8ea-bcb29466ae2a" alt="image" width="700"> </br>

🌱 ***İstatistikler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/bee2a036-64a8-4933-bbb5-4b45d3b67666" alt="image" width="700"> </br>

🌱 ***Masalar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/37c2d364-8208-4553-babb-54de3a9d71a8" alt="image" width="700"> </br>

🌱 ***Masa Durumları Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/0e7162bd-b097-4bd1-ae7f-a0ddf7a88fe5" alt="image" width="700"> </br>

🌱 ***Mesajlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/502bd7c7-7f2b-433d-a30e-8aee9f086f95" alt="image" width="700"> </br>

🌱 ***Bildirimler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/35b1483e-737c-4679-a85d-6b35f469952e" alt="image" width="700"> </br>

🌱 ***Anlık Durum Çubuğu Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/24ebe671-adfe-408e-8087-9dd8b63b150f" alt="image" width="700"> </br>

🌱 ***Ayarlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/ec529e0d-e71a-4112-9be1-5ebd5b43c4e1" alt="image" width="700"> </br>

🌱 ***Mail İşlemleri Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/a22ef9b0-429a-47c8-99c4-d0cb63e28f29" alt="image" width="700"> </br>

🌱 ***QR Kod Oluşturma Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/460b1e14-022c-4fe6-9209-8449ebf0d344" alt="image" width="700"> </br>

-----------------------------------------------------------------------
#### 📋 Projenin Yönetimi

Proje yönetimi sürecinde, **Jira** kullanılarak proje daha verimli bir şekilde yönetilmiştir. Jira'nın sunduğu güçlü araçlar sayesinde, tüm görevler düzenli bir şekilde takip edilmiş ve her adım belirli bir düzende ilerletilmiştir. Kanban iş akışı kullanılarak, yapılacak işler öncelik sırasına konmuş ve her aşama net bir şekilde izlenerek zamanında tamamlanmıştır.

-----------------------------------------------------------------------

#### 🗂️ Proje Veri Tabanı Yedek Dosyası

Projenin MsSQL veri tabanı yedek dosyasını aşağıdaki linkten indirebilirsiniz. Bu dosya, QuickBites projesine ait tüm ürünler, kategoriler, randevular ve diğer veri tabanı yapılarıyla birlikte gelir. Dosyayı indirerek yerel ortamınızda projeyi çalıştırabilirsiniz.

📥 [**Veri Tabanı Yedeğini İndir**](https://drive.google.com/file/d/1hg38TwYHdTeQ01l1lBqWH1y994E0tMiw/view?usp=sharing)

-----------------------------------------------------------------------

İyi Çalışmalar! 🎉
