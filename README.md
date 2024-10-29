Bu proje, .NET ve SignalR kullanılarak geliştirilmiş temel bir chat uygulamasıdır. Proje, kullanıcıların gerçek zamanlı olarak sohbet etmelerini sağlamak için SignalR'ı kullanırken SQL veritabanında verilerini saklar. Bu README dosyası, projenin genel yapısını, gereksinimlerini ve kurulumu hakkında bilgiler sunmaktadır.
<br>
📝 Özellikler<br>
Gerçek Zamanlı Mesajlaşma: SignalR ile hızlı ve düşük gecikmeli iletişim.<br>
Kullanıcı Yönetimi: Her kullanıcının oturum açması gerekir.<br>
Mesaj Depolama: Gönderilen ve alınan mesajlar SQL veritabanında saklanır.<br>
Kullanıcı Dostu Arayüz: Temiz ve minimalist arayüz ile kullanım kolaylığı.<br>
📌 Teknolojiler <br>
Backend: .NET Core<br>
Gerçek Zamanlı İletişim: SignalR<br>
Veritabanı: SQL Server<br>
Diğer: ASP.NET Core MVC<br>
⚙️ Kurulum<br>
Gereksinimler<br>
.NET SDK 6.0 veya üstü<br>
SQL Server (Express veya daha üst bir sürüm)<br>
Git<br>
Yükleme Adımları<br>
Projeyi GitHub'dan klonlayın:<br>

bash<br>
Kodu kopyala<br>
git clone https://github.com/muhammederencennetkusu/dotnet-basic-chatapp<br>
cd chatapp-projesi<br>
Gerekli bağımlılıkları yükleyin:<br>

bash<br>
Kodu kopyala<br>
dotnet restore<br>
SQL Server'da bir veritabanı oluşturun ve bağlantı bilgilerini appsettings.json dosyasına ekleyin.<br>
<br>
Veritabanı tablolarını oluşturmak için dotnet ef komutlarını çalıştırarak tabloları kurun:<br>

bash<br>
Kodu kopyala<br>
dotnet ef database update<br>
Uygulamayı başlatın:<br>

bash<br>
Kodu kopyala<br>
dotnet run<br>
Tarayıcınızda http://localhost:5000 adresini açarak uygulamayı görüntüleyin.<br>

🚀 Kullanım<br>
Anasayfada oturum açarak veya kayıt olarak kullanıcı adı ile giriş yapın.<br>
Kullanıcı adı seçtikten sonra sohbet odasına katılabilir ve mesaj gönderebilirsiniz.<br>
Gönderilen mesajlar diğer kullanıcıların ekranlarında anında görünecektir.<br>
