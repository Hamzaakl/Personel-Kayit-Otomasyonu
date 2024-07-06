
# Personel Kayıt Otomasyonu

Bu proje, C# kullanarak geliştirilmiş bir personel kayıt otomasyon sistemidir. Sistem, SQL veritabanı ile etkileşimde bulunarak personel kayıtlarını ekleme, güncelleme, silme ve kaydetme işlemlerini gerçekleştirir.

## Proje Yapısı

Proje aşağıdaki ana bileşenlerden oluşmaktadır:

1. **Veritabanı Bağlantısı**
2. **Personel İşlemleri**
    - Ekleme
    - Güncelleme
    - Silme
    - Kaydetme
3. **Kullanıcı Arayüzü**

### 1. Veritabanı Bağlantısı

Proje, SQL Server ile etkileşimde bulunur. Bağlantı dizgesi (`connection string`), uygulamanın veritabanına bağlanabilmesi için gereklidir. Bu dize, veritabanı sunucusunun adresini, veritabanı adını, kullanıcı adını ve şifresini içerir.

### 2. Personel İşlemleri

#### Ekleme

Yeni personel kayıtları eklemek için aşağıdaki adımlar izlenir:
1. Kullanıcı, arayüzdeki gerekli alanları doldurur.
2. "Ekle" butonuna tıklanır.
3. Sistem, girilen verileri alarak SQL `INSERT` komutu ile veritabanına ekler.

#### Güncelleme

Mevcut personel kayıtlarını güncellemek için aşağıdaki adımlar izlenir:
1. Güncellenecek personel kaydı seçilir.
2. İlgili alanlar düzenlenir.
3. "Güncelle" butonuna tıklanır.
4. Sistem, düzenlenen verileri alarak SQL `UPDATE` komutu ile veritabanında günceller.

#### Silme

Personel kayıtlarını silmek için aşağıdaki adımlar izlenir:
1. Silinecek personel kaydı seçilir.
2. "Sil" butonuna tıklanır.
3. Sistem, seçilen kaydı SQL `DELETE` komutu ile veritabanından siler.

#### Kaydetme

Yapılan değişikliklerin tamamını kaydetmek için:
1. "Kaydet" butonuna tıklanır.
2. Sistem, yapılan tüm değişiklikleri veritabanına yansıtır.

### 3. Kullanıcı Arayüzü

Arayüzde, personel ekleme, güncelleme, silme ve kaydetme işlemlerini gerçekleştirebileceğiniz alanlar bulunmaktadır.



