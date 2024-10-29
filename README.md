Bu proje, .NET ve SignalR kullanılarak geliştirilmiş temel bir chat uygulamasıdır. Proje, kullanıcıların gerçek zamanlı olarak sohbet etmelerini sağlamak için SignalR'ı kullanırken SQL veritabanında verilerini saklar. Bu README dosyası, projenin genel yapısını, gereksinimlerini ve kurulumu hakkında bilgiler sunmaktadır.

📝 Özellikler
Gerçek Zamanlı Mesajlaşma: SignalR ile hızlı ve düşük gecikmeli iletişim.
Kullanıcı Yönetimi: Her kullanıcının oturum açması gerekir.
Mesaj Depolama: Gönderilen ve alınan mesajlar SQL veritabanında saklanır.
Kullanıcı Dostu Arayüz: Temiz ve minimalist arayüz ile kullanım kolaylığı.
📌 Teknolojiler
Backend: .NET Core
Gerçek Zamanlı İletişim: SignalR
Veritabanı: SQL Server
Diğer: ASP.NET Core MVC
⚙️ Kurulum
Gereksinimler
.NET SDK 6.0 veya üstü
SQL Server (Express veya daha üst bir sürüm)
Git
Yükleme Adımları
Projeyi GitHub'dan klonlayın:

bash
Kodu kopyala
git clone https://github.com/muhammederencennetkusu/dotnet-basic-chatapp
cd chatapp-projesi
Gerekli bağımlılıkları yükleyin:

bash
Kodu kopyala
dotnet restore
SQL Server'da bir veritabanı oluşturun ve bağlantı bilgilerini appsettings.json dosyasına ekleyin.

Veritabanı tablolarını oluşturmak için dotnet ef komutlarını çalıştırarak tabloları kurun:

bash
Kodu kopyala
dotnet ef database update
Uygulamayı başlatın:

bash
Kodu kopyala
dotnet run
Tarayıcınızda http://localhost:5000 adresini açarak uygulamayı görüntüleyin.

🚀 Kullanım
Anasayfada oturum açarak veya kayıt olarak kullanıcı adı ile giriş yapın.
Kullanıcı adı seçtikten sonra sohbet odasına katılabilir ve mesaj gönderebilirsiniz.
Gönderilen mesajlar diğer kullanıcıların ekranlarında anında görünecektir.
