# Hastane Randevu ve Yönetim Projesi
# 🏥 Hastane Otomasyon Sistemi

Bu proje, bir hastanenin **hasta, doktor, branş, sekreter, duyuru ve randevu** işlemlerini kolayca yönetmesini sağlayan bir masaüstü uygulamasıdır.  
Uygulama **Asp.net** ile geliştirilmiş, **SQL Server** veritabanı kullanmaktadır.

---

## 📦 Kurulum

1. **Setup dosyasını indirin**  
   - GitHub Releases bölümünden `setup.zip` dosyasını indirin.  
   - Zip içeriğini çıkarın.

2. **Programı yükleyin**  
   - Çıkan `setup.exe` dosyasına çift tıklayın ve kurulum sihirbazını takip edin.

3. **Veritabanını yükleyin**  
   - Proje ile birlikte gelen `HastaneProje.bak` dosyasını SQL Server Management Studio (SSMS) kullanarak geri yükleyin:  
     - SSMS’i açın.  
     - **Databases** üzerine sağ tıklayın → **Restore Database** seçin.  
     - **Device** seçeneğinden `.bak` dosyasını ekleyin ve yükleyin.

4. **Bağlantı ayarlarını yapın**  
   - Uygulama, SQL Server bağlantı bilgilerini dışarıdan`hastane.txt` dosyasından okur.  
   - Bu dosyayı içerisine kendi SQL Server bağlantı cümlenizi (`connection string`) aşağıdaki formatta girin:

     ```
     Data Source=SERVER_ADI;Initial Catalog=VeritabaniAdi;Integrated Security=True
     ```

   - `SERVER_ADI` kısmına kendi bilgisayarınızdaki SQL Server adını,  
     `VeritabaniAdi` kısmına ise "HastaneProje" veritabanı adını yazın.  


---

## ▶️ Kullanım

- **Sekreter** giriş yaparak:
  - Doktor ekleme, silme, güncelleme
  - Branş ekleme
  - Duyuru yayınlama
  - Randevu oluşturma işlemlerini yapabilir.

- **Doktor** giriş yaparak:
  - Kendi randevularını görüntüleyebilir.
  - Hasta bilgilerine ulaşabilir.
  - Doktor bilgilerine ulaşabilir güncelleyebilir.
    
- **Hasta** giriş yaparak:
  - Geçmiş randevularını görüntüleyebilir.
  - Branş ve doktor seçerek aktif randevuları görüntüleyebilir ve seçebilir.
  - Hasta bilgilerine ulaşabilir ve güncelleyebilir.
 
---

## 📷 Ekran Görüntüleri

> <img width="1577" height="861" alt="Ekran görüntüsü 2025-08-10 114724" src="https://github.com/user-attachments/assets/db897196-f51f-4214-beb3-cfc501a85963" />
<img width="1546" height="812" alt="Ekran görüntüsü 2025-08-10 114736" src="https://github.com/user-attachments/assets/989e4982-e34b-4cd4-802e-499bb6bd57c6" />
<img width="1560" height="831" alt="Ekran görüntüsü 2025-08-10 114757" src="https://github.com/user-attachments/assets/39a58a4a-cc2d-4bf4-a3f0-2ff1210ffa77" />
> <img width="1556" height="831" alt="Ekran görüntüsü 2025-08-10 114846" src="https://github.com/user-attachments/assets/a24f8552-94ac-4de3-9d49-130b04c3da38" />
> <img width="1561" height="828" alt="Ekran görüntüsü 2025-08-10 114906" src="https://github.com/user-attachments/assets/3eeb601f-c0f3-4ede-9d80-a2757e0da4e8" />
> <img width="1567" height="840" alt="Ekran görüntüsü 2025-08-10 114927" src="https://github.com/user-attachments/assets/0aa8c2e6-7d44-4876-9ef2-9a2aa5d82424" />
<img width="1532" height="802" alt="Ekran görüntüsü 2025-08-10 114940" src="https://github.com/user-attachments/assets/dd090bdc-7758-4497-b57a-0a4b573a0302" />
> <img width="1528" height="832" alt="Ekran görüntüsü 2025-08-10 114952" src="https://github.com/user-attachments/assets/cb321c07-7cdc-4c03-ac29-59dcde58a44a" />
<img width="1528" height="832" alt="Ekran görüntüsü 2025-08-10 114952" src="https://github.com/user-attachments/assets/e019186b-c78f-472b-825d-a37f8fd0b199" />
<img width="1537" height="807" alt="Ekran görüntüsü 2025-08-10 115004" src="https://github.com/user-attachments/assets/bd9646e6-bfaa-4139-b950-385b844f9a30" />
<img width="1540" height="512" alt="Ekran görüntüsü 2025-08-10 115023" src="https://github.com/user-attachments/assets/df6b0b1d-016d-4f07-958e-2ab41c46df1e" />










---



