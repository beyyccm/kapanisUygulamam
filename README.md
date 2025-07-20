# 🚗 Araba Üretim Simülasyonu (Hafta 5 - Kapanış)

Bu C# projesi, kullanıcı ile etkileşimli bir şekilde araba üretimini simüle eder. Uygulama, `Araba` sınıfı ve temel programlama yapılarını (class, liste, döngü, try-catch, goto) kullanarak basit bir nesne tabanlı uygulama örneği sunar.

---

## 🧰 Kullanılan Teknolojiler

- **Dil:** C#
- **Platform:** .NET (Console App)
- **IDE:** Visual Studio / Rider / VS Code

---

## 🎯 Uygulama Amacı

- `class` ve `object` yapısını kavratmak  
- Kullanıcıdan veri alma, kontrol etme ve hata yönetimini öğretmek  
- Liste yapısıyla birden fazla nesnenin saklanmasını sağlamak  
- Giriş doğrulama (`try-catch`) ve yönlendirme (`goto`) uygulamalarını göstermek  

---

## 📌 Özellikler

- Kullanıcıya araba üretmek isteyip istemediği sorulur.
- Üretmek isterse:
  - **Seri No**, **Marka**, **Model**, **Renk** bilgileri kullanıcıdan alınır.
  - **Üretim Tarihi** otomatik olarak `DateTime.Now` ile atanır.
  - **Kapı Sayısı** yalnızca sayısal girilebilmesi için kontrol edilir (`try-catch` ve `goto`).
- Her üretilen araba `List<Araba>` listesine eklenir.
- Kullanıcı araba üretmek istemediğini belirttiğinde, liste ekrana yazdırılır: sadece **Seri No** ve **Marka** bilgileri gösterilir.

---

## 🔄 Program Akışı

1. Başlangıçta kullanıcıya araba üretmek isteyip istemediği sorulur (`E/H`).
2. `E` derse araba üretme süreci başlar.
3. Her araba için bilgileri girer, doğrulama yapılır.
4. Araba listeye eklenir.
5. Kullanıcı tekrar araba üretmek isteyip istemediğini belirler.
6. `H` derse, üretilen tüm arabaların Seri No ve Marka bilgileri listelenir.

---


       
