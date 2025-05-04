# ASP.NET Core MVC İletişim Formu Uygulaması

Bu proje, **ASP.NET Core MVC** ve **MS SQL Server** kullanılarak geliştirilmiş basit bir iletişim formu uygulamasıdır.  
Kullanıcılar; ad soyad, telefon, e-posta, departman ve mesaj bilgilerini doldurarak formu gönderebilir.

## 📸 Ekran Görüntüleri
![Form Görünümü](https://github.com/user-attachments/assets/5ffc4058-4e2c-4507-93d3-7398601beed8)
![Başarı Mesajı](https://github.com/user-attachments/assets/bbc3607d-dea4-4a07-8e5c-cf4ffc6150dd)
![Geçersiz Veri Girişi](https://github.com/user-attachments/assets/9c0d8d08-ca4e-441c-9d68-bcfda87f0846)
![Boş Bırakma](https://github.com/user-attachments/assets/0bed0ebd-4474-45e4-b0f4-51d7f789fad7)

## 🧰 Kullanılan Teknolojiler

- ASP.NET Core MVC (örn. .NET 6 / .NET 7)
- Entity Framework Core
- Microsoft SQL Server
- Bootstrap

## 📋 Form Alanları

- Ad Soyad
- Telefon (05 ile başlamalı ve 11 haneli olmalı)
- E-posta
- Departman (Seçmeli: Muhasebe, Teknik Destek, İnsan Kaynakları)
- Mesaj

## ✅ Doğrulama Kuralları

- Tüm alanlar zorunludur.
- Telefon numarası `05xxxxxxxxx` formatında olmalıdır.
- Ad Soyad: minimum 5, maksimum 50 karakter
- Mesaj: minimum 25, maksimum 500 karakter

## ⚙️ Nasıl Çalıştırılır?

1. Projeyi klonlayın veya Visual Studio ile açın.
2. `appsettings.json` dosyasındaki veritabanı bağlantısını kendinize göre düzenleyin.
3. Paket Yöneticisi Konsolu’nda aşağıdaki komutları çalıştırın:
    Add-Migration InitialCreate
    Update-Database
4. Uygulamayı başlatın (`F5` veya `Ctrl + F5`).

## 📝 Notlar

- Bu proje bir staj başvurusuna yönelik ödev olarak hazırlanmıştır.
- E-posta gönderme veya kullanıcı doğrulama (login) işlemleri dahil değildir.
- Doğrulama mesajları Türkçedir.

## 📄 Lisans

Bu proje eğitim ve tanıtım amaçlıdır. Telif hakkı içermez.
