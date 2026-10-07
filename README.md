<div align="center">

# E-Ticaret Ürün Kataloğu

**ASP.NET Core MVC eğitim uygulaması**

![C#](https://img.shields.io/badge/C%23-2563eb?style=flat-square)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core%20MVC-0891b2?style=flat-square)
![Razor](https://img.shields.io/badge/Razor-7c3aed?style=flat-square)
[![MIT License](https://img.shields.io/badge/License-MIT-16a34a?style=flat-square)](LICENSE)

Ürünleri bellek içi bir listeden Razor görünümlerine aktaran, MVC veri akışını örnekleyen web uygulaması.

</div>

---

## Öne Çıkanlar

- Model, controller ve view ilişkisi
- Ürün adı, fiyatı ve görsellerinin listelenmesi
- Bootstrap ile web arayüzü; veritabanı gerektirmez

## Teknolojiler

C# · ASP.NET Core MVC · Razor

## Teknik yaklaşım

Product modeli ve ProductController bellek içi ürün verisini Razor görünümlerine taşır. MVC katmanları arasındaki veri akışı küçük bir katalog örneğiyle gösterilir.

## Kodu incelemeye başlayın

- [ETicaretProjesi/Controllers/HomeController.cs](ETicaretProjesi/Controllers/HomeController.cs)
- [ETicaretProjesi/Controllers/ProductController.cs](ETicaretProjesi/Controllers/ProductController.cs)
- [ETicaretProjesi/Program.cs](ETicaretProjesi/Program.cs)
- [ETicaretProjesi/Models/ErrorViewModel.cs](ETicaretProjesi/Models/ErrorViewModel.cs)

## Kapsam ve sınırlar

Ürün kataloğu eğitim uygulamasıdır; kalıcı veri, gerçek ödeme ve sipariş yönetimi kapsamına girmez.

<details>
<summary><strong>Kurulum, kullanım ve teknik ayrıntılar</strong></summary>

Bu proje, ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş basit bir e-ticaret uygulamasıdır. Amaç, MVC yapısını öğrenmek ve ürün listeleme mantığını pratik olarak uygulamaktır.

---

## Proje Hakkında

Bu uygulamada ürünler dinamik olarak bir liste içerisinde tanımlanmış ve kullanıcıya web arayüzü üzerinden sunulmuştur.

Proje kapsamında:

- ASP.NET Core MVC yapısı
- Controller mantığı
- View (Razor) kullanımı
- Model yapısı
- Statik ürün listeleme (in-memory data)

kullanılmıştır.

---

## Teknik Detaylar

| Özellik | Açıklama |
|---|---|
| Dil | C# |
| Framework | ASP.NET Core MVC |
| Mimari | MVC (Model - View - Controller) |
| Veritabanı |  Yok (in-memory liste kullanıldı) |
| Frontend | HTML, CSS, Bootstrap |
| IDE | Visual Studio 2022 |

---

## Kullanılan Teknolojiler

- ASP.NET Core MVC
- C#
- Razor Views
- Bootstrap
- HTML5 / CSS3
- MVC Pattern

---

## Proje Yapısı

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

## Önemli Dosyalar

## ProductController.cs
Ürünleri listeleyen ve View’a gönderen controller yapısı.

- Ürünler manuel olarak `List<Product>` içinde tanımlanmıştır.
- Veritabanı kullanılmamıştır.

## HomeController.cs
- Ana sayfa (Index)
- Privacy sayfası
- Error sayfası yönetimi

## Product.cs
Ürün modelini temsil eder:

- Id
- Name
- Price
- ImageUrl
- Description

---

## Projenin Amacı

Bu proje sayesinde:

- MVC mantığı öğrenilir
- Controller → View veri aktarımı anlaşılır
- Model yapısı pratik edilir
- ASP.NET Core temel seviyede kavranır
- Basit e-ticaret ürün listeleme sistemi geliştirilir

---

## Not

Bu projede **veritabanı kullanılmamaktadır.**  
Ürün verileri doğrudan `ProductController` içerisinde sabit olarak tanımlanmıştır.

---


</details>

---

<div align="center">

**© 2025 Şilan PEHLİVAN**

Bu proje MIT lisansı kapsamında sunulmaktadır. Kullanım ve dağıtım koşulları: [LICENSE](LICENSE).

</div>
