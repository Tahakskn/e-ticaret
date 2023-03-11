
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proje.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler=new List<Category>()
            {
                new Category(){Name = "Siteler",Description=" Hazır Siteler"},
                new Category(){Name = "Bilgisayar",Description=" Bilgisayar Ürünleri"},
                new Category(){Name = "Elektronik",Description=" Elektronik Ürünleri"},
                new Category(){Name = "Telefon",Description=" Telefon Ürünleri"},
                new Category(){Name = "Kamera",Description=" Kamera Ürünleri"},
                new Category(){Name = "Beyaz Eşya",Description=" Beyaz Eşya Ürünleri"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

             var urunler = new List<Product>()
            {
                new Product(){Name="Dernek & Belediye",Description="Dernek & Belediye Web Sitesi Demo",Price=1000,stock=100,IsApproved=true,CategoryId=1,IsHome=true,Image="a.jpg"},
                new Product(){Name="Otel – Bar & Restaurant",Description="WordPress Kurumsal Demolar",Price=1499,stock=20,IsApproved=true,CategoryId=1,IsHome=true,Image="a2.jpg"},
                new Product(){Name="WATERLAVA",Description="Kampanya Dahilinde 1.499 TL Web Site Demoları",Price=1499,stock=30,IsApproved=false,CategoryId=1,Image="a3.jpg"},
                new Product(){Name="Tekstil & Moda",Description="PHP Demolar",Price=2500,stock=5,IsApproved=false,CategoryId=1,Image="a3.jpg"},
                new Product(){Name="Mimarlık & İnşaat",Description="WordPress Kurumsal Demolar",Price=5000,stock=14,IsApproved=true,CategoryId=1,Image="a2.jpg"},

                new Product(){Name="Sinerji Hestia Intel Core i3 12100F 16GB 512GB NVMe M.2 SSD RX6700 [Oyun Bilgisayarı]",Description="Sinerji Hestia Intel Core i3 12100F 16GB 512GB NVMe M.2 SSD RX6700 [Oyun Bilgisayarı] özellikleri aşağıda listelenmiştir. Ürün ile ilgili aklınıza takılan diğer tüm sorular için bize ulaşabilirsiniz.",Price=13899,stock=50,IsApproved=true,CategoryId=2,Image="a2.jpg"},
                new Product(){Name="Sinerji Koi Ryzen 5 5600 16GB 512GB NVMe M.2 SSD RTX3060Ti [Oyun Bilgisayarı]",Description="NVIDIA’nın Founders Edition RTX 3060 Ti sürümünü inceliyoruz. Sıcaklık ve performans değerleri ASUS, MSI ve Gigabyte gibi üreticilerin Partner sürümü denilen modellerinde, modelden modele farklılık gösterecektir",Price=16499,stock=20,IsApproved=true,CategoryId=2,Image="a3.jpg"},
                new Product(){Name="EASTER-EG1 / INTEL i5-12400F / ASUS GeForce DUAL RTX 3060 V2 OC 12GB / 16GB RAM / 500GB M.2 SSD Gaming Bilgisayar",Description="inovasyona ve performansa adanmış yapısıyla arka arkaya 10 yıldan fazla bir süredir dünyanınlider anakartmarkasıdır. Aynı zamanda en çok ödül kazanan ve toplamda 580 milyon adetten daha fazla satış adeti ile en çok satanmarkadır.İster iş ister oyun için bir sistem toplayın, farklı model seçenekleri ve yenilikçi özellikler sayesindeihtiyaçlarınıza en uygun anakartı ASUS anakartların içinden kolayca bulabilirsiniz.",Price=15687,stock=18,IsApproved=false,CategoryId=2,IsHome=true,Image="a.jpg"},
                new Product(){Name="EPIC-3070 / INTEL i5-12400F / MSI GeForce RTX 3070 VENTUS 2X OC LHR 8GB / 16GB RAM / 500GB M.2 SSD Gaming Bilgisayar",Description="Core i5-12400F 2.5GHz 18MB Önbellek 12 Çekirdek 1700 10nm İşlemci",Price=25699,stock=20,IsApproved=true,CategoryId=2,Image="a.jpg"},
                new Product(){Name="Wisp Intel i7 13700K 32GB 1TB NVMe M.2 SSD RTX4080 [Oyun Bilgisayarı]",Description="ASUS inovasyona ve performansa adanmış yapısıyla arka arkaya 10 yıldan fazla bir süredir dünyanın lider anakart markasıdır. Aynı zamanda en çok ödül kazanan ve toplamda 580 milyon adetten daha fazla satış adeti ile en çok satan markadır.",Price=72999,stock=31,IsApproved=true,CategoryId=2,IsHome=true,Image="a2.jpg"},

                new Product(){Name="Xiaomi Mi Box S 4K Android Tv Box",Description="Son yıllarda ürettiği elektronik ürünler sayesinde adından söz ettirmeyi başaran Xiaomi'nin akıllı TV kutusu Xiaomi Mi Box S 4K Android TV Box Media Player, global versiyonu ve Türkçe dil desteği ile kullanıcıların beğenisini kazanıyor. Hızlı işlemcisi, güçlü grafik yongası ve 4K desteği ile gelen Xiaomi Mi Box S 4K Android TV Box Media Player, yüksek görüntü ve ses performansı sunuyor. ",Price=1298 ,stock=10,IsApproved=true,CategoryId=3,IsHome=true,Image="a3.jpg"},
                new Product(){Name="Dyson V15 Detect Absolute Kablosuz Süpürge",Description="Dyson V15 Detect Absolute Kablosuz Süpürge oldukça güçlü bir süpürge modeli olması nedeniyle tercih ediliyor. Kıvrak hareket kabiliyeti nedeniyle halı gibi zorlu yüzeylerde bile kolay hareket etme özelliğine sahip",Price=14999,stock=20,IsApproved=true,CategoryId=3,Image="a.jpg"},
                new Product(){Name="Blaupunkt BL55145G UHD Smart Uydu Alıcılı LED Tv",Description="Daha fazlasını istiyorsanız, UHD 4K teknolojisini tercih edin! Android 9 Google tarafından geliştirilen Android sistem, Android TV’lerle evinize taşınıyor! Bu sayede ,TV’nizi telefon ya da tabletinizle kontrol edebilirsiniz. Android TV ile en yeni filmler, diziler, TV programları ve oyunlar elinizin altında olacak!",Price=11449,stock=30,IsApproved=false,CategoryId=3,Image="a2.jpg"},
                new Product(){Name="Xiaomi Mi Robot Vacuum Mop 2 Pro Akıllı Robot Süpürge - Beyaz",Description="Yaşam alanlarının temizliği oldukça önemlidir. Özellikle sağlık açısından temizliğin düzenli olarak yapılması gerekir. Özellikle çocuklu aileler ve evcil hayvan bakımı yapan kişiler için ev temizliği zorlayıcı olabilir",Price=7999,stock=5,IsApproved=false,CategoryId=3,Image="a2.jpg"},
                new Product(){Name="Xiaomi Mi Home Security Camera 360° Ev Güvenlik Kamerası Ip 1080P",Description="Mi Home Security Camera 360°1080P Değer verdiğiniz şeyleri koruyun 1080p FHD | 360° Görüş|Kızılötesi Gece Görüşü | Yapay Zeka destekli hareket algılama 360° görüş şunları sunar: Eksiksiz ev koruması Çift motor başlığı, kameranın tam 360° yatay ve 96° dikey şekilde dönmesini ve çekim yapmasını sağlar.",Price=749,stock=14,IsApproved=true,CategoryId=3,IsHome=true,Image="a5.jpg"},

                new Product(){Name="TCL 30 Plus 128 GB 4 GB Ram (TCL Türkiye Garantili)",Description="TCL 30 Plus, sadeliğiyle zarif bir telefon arayan kişilerin ilgisini çeker. Plastik arka kapak, mat bir yüzeye sahip olduğu için elde rahat bir şekilde tutulabilir. ",Price=5550,stock=10,IsApproved=true,CategoryId=4,Image="a2.jpg"},
                new Product(){Name="iPhone 11 128 GB",Description="Yeni çift kamerası ile tüm gün süren pil ömrü(yalan btw) bir akıllı tel için dayanıklı cam  bla lba",Price=17199,stock=20,IsApproved=true,CategoryId=4,Image="a3.jpg"},
                new Product(){Name="Nokıa 5130 C",Description="Nokia 5130 C Tuşlu Kamerasız UZUN ŞARJ SÜRESİ YÜKSEK SES KALİTESİ asker telefonu",Price=415,stock=30,IsApproved=false,CategoryId=4,Image="a2.jpg"},
                new Product(){Name="Xiaomi Redmi Note 10 Pro 256 GB 8 GB Ram (Xiaomi Türkiye Garantili)",Description="Xiaomi Redmi Note 10 Pro 256 GB 8 GB RAM akıllı telefon modeli hem tasarımı hem de teknik özellikleri ile kullanıcılardan övgüler topluyor.",Price=8.500,stock=5,IsApproved=false,CategoryId=4,IsHome=true,Image="a2.jpg"},
                new Product(){Name="Xiaomi Mi 12T Pro 256 GB 12 GB Ram (Xiaomi Türkiye Garantili)",Description="Öncelikle telefonun en  beğendiğim özelliği 20 dakika gibi kısa bir sürede tamamen şarj olması. içerik üretiyorsanız ve sosyal medyada çok zaman geçiriyorsanız, gerek kamerasıyla gerekse işlemci hızıyla işinizi oldukça kolaylaştıracak bir cihaz diyebilirim",Price=27750,stock=14,IsApproved=true,CategoryId=4,Image="a2.jpg"},

                new Product(){Name="Polaroid Now Siyah Instant Fotoğraf Makinesi",Description="Polaroid Now Fotoğraf Makinesi, hayatınızın her anını fotoğraflamak için üretilmiş, bas-çek analog anlık fotoğraf makinası modellerinden biridir.",Price=2.894,stock=10,IsApproved=true,CategoryId=5,IsHome=true,Image="a3.jpg"},
                new Product(){Name="Canon Powershot G7 X Mark II Siyah Fotoğraf Makinesi (Canon Eurasia Garantili)",Description="Beklentilerin ötesine geçen ve akıllı telefonunuzda görmeye alışık olduğunuz içerikleri bir hayli geride bırakan içerikler üretin. Muhteşem 4K video, göz alıcı 20,1 megapiksel fotoğraf ve yüksek hızda çekim sayesinde uçup giden anları ölümsüzleştirin.",Price=15699,stock=20,IsApproved=true,CategoryId=5,Image="a3.jpg"},
                new Product(){Name="Panasonic Lumix DMC-FZ300",Description="12.1MP 1/2.3 MOS Sensör Venus Engine Görüntü İşlemcisi Leica DC Vario-Elmarit f/2.8 Lens",Price=10597,stock=30,IsApproved=false,CategoryId=5,Image="a.jpg"},
                new Product(){Name="Sony RX10 Mark IV Fotoğraf Makinesi (Sony Eurasia Garantili)",Description="Sony RX10 Mark IV Dijital Fotoğraf Makinesi ( Sony Eurasia Garantilidir )",Price=36499,stock=5,IsApproved=false,CategoryId=5,IsHome=true,Image="a2.jpg"},
                new Product(){Name="Nikon P950 Coolpix Fotoğraf Makinesi",Description="16MP 1 / 2.3 BSI CMOS SensörNIKKOR 83x Optik Zum Objektif24-2000mm (35mm Eşdeğeri)UHD 4K30 ve Full HD 60p Video",Price=19579,stock=14,IsApproved=true,CategoryId=5,Image="a3.jpg"},

                //new Product(){Name="buzdolabı",Description="sogutur",Price=30000,stock=14,IsApproved=true,CategoryId=6,IsHome=true}



            };
                
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);

            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}