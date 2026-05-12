# 🛒 ASP.NET Core MVC E-Ticaret Projesi

Bu proje, ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş basit bir e-ticaret uygulamasıdır. Amaç, MVC yapısını öğrenmek ve ürün listeleme mantığını pratik olarak uygulamaktır.

---

# 📝 Proje Hakkında

Bu uygulamada ürünler dinamik olarak bir liste içerisinde tanımlanmış ve kullanıcıya web arayüzü üzerinden sunulmuştur.

Proje kapsamında:

- ASP.NET Core MVC yapısı
- Controller mantığı
- View (Razor) kullanımı
- Model yapısı
- Statik ürün listeleme (in-memory data)

kullanılmıştır.

---

# ⚙️ Teknik Detaylar

| Özellik | Açıklama |
|---|---|
| Dil | C# |
| Framework | ASP.NET Core MVC |
| Mimari | MVC (Model - View - Controller) |
| Veritabanı | ❌ Yok (in-memory liste kullanıldı) |
| Frontend | HTML, CSS, Bootstrap |
| IDE | Visual Studio 2022 |

---

# 🚀 Kullanılan Teknolojiler

- ASP.NET Core MVC
- C#
- Razor Views
- Bootstrap
- HTML5 / CSS3
- MVC Pattern

---

# 📦 Proje Yapısı

```bash
ETicaretProjesi/
│
├── Controllers/
│   ├── HomeController.cs
│   └── ProductController.cs
│
├── Models/
│   ├── Product.cs
│   └── ErrorViewModel.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   │
│   ├── Product/
│   │   └── Index.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       └── Error.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── Program.cs
├── appsettings.json
└── ETicaretProjesi.csproj
```

---

# 📌 Önemli Dosyalar

## 🧠 ProductController.cs
Ürünleri listeleyen ve View’a gönderen controller yapısı.

- Ürünler manuel olarak `List<Product>` içinde tanımlanmıştır.
- Veritabanı kullanılmamıştır.

## 🏠 HomeController.cs
- Ana sayfa (Index)
- Privacy sayfası
- Error sayfası yönetimi

## 📦 Product.cs
Ürün modelini temsil eder:

- Id
- Name
- Price
- ImageUrl
- Description

---

# 🎯 Projenin Amacı

Bu proje sayesinde:

- MVC mantığı öğrenilir
- Controller → View veri aktarımı anlaşılır
- Model yapısı pratik edilir
- ASP.NET Core temel seviyede kavranır
- Basit e-ticaret ürün listeleme sistemi geliştirilir

---

# ⚠️ Not

Bu projede **veritabanı kullanılmamaktadır.**  
Ürün verileri doğrudan `ProductController` içerisinde sabit olarak tanımlanmıştır.

---

## 📜 Lisans

Bu proje **MIT License** ile lisanslanmıştır. Detaylı bilgi için `LICENSE` dosyasını inceleyebilirsiniz.

## 👩‍💻 Geliştirici

Şilan Pehlivan
