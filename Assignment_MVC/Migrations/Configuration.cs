namespace Assignment_MVC.Migrations
{
    using Assignment_MVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_MVC.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment_MVC.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category() { Id = 1, Name = "Quần áo bé trai" },
                new Category() { Id = 2, Name = "Quần áo bé gái" },
                new Category() { Id = 3, Name = "Giày bé trai" },
                new Category() { Id = 4, Name = "Giày bé gái" },
                new Category() { Id = 5, Name = "Nón" },
                new Category() { Id = 6, Name = "Balo" });
            context.Products.AddOrUpdate(x => x.Id,
                new Product()
                {
                    Id = 1, Name = "Áo dài chim phụng mùa xuân cho bé trai", CategoryId = 1,
                    Description = "Áo dài chim phụng mùa xuân cho bé trai từ 1-13 tuổi", Quantity = 100, Discount = 15,
                    UnitPrice = 100000,
                    Image =
                        "https://cdn.becungshop.vn/images/500x500/ao-dai-chim-phung-mua-xuan-cho-be-trai-tu-1-13-tuoi-p24435172f0f14-500x500.jpg"
                },
                new Product()
                {
                    Id = 2, Name = "Đầm công chúa THIÊN NGAN cho bé gái", CategoryId = 2,
                    Description = "Đầm công chúa THIÊN NGAN cho bé gái", Quantity = 100, Discount = 15,
                    UnitPrice = 150000,
                    Image = "https://cdn.becungshop.vn/images/500x500/dam-cong-chua-thien-ngan-cho-be-gai-p244348c66f27b-500x500.jpg"
                },
                 new Product()
                 {
                     Id = 3,
                     Name = "Đầm công chúa cho bé gái",
                     CategoryId = 2,
                     Description = "Đầm công chúa phối dạ thu đông kèm nón bánh tiêu cho bé từ 3-8 tuổi",
                     Quantity = 10,
                     Discount = 15,
                     UnitPrice = 160000,
                     Image = "https://cdn.becungshop.vn/images/500x500/dam-cong-chua-phoi-da-thu-dong-kem-non-banh-tieu-cho-be-tu-3-8-tuoi-p24415754169d3-500x500.jpg"
                 },
                new Product()
                {
                    Id = 4,
                    Name = "Đầm công chúa cho bé gái",
                    CategoryId = 2,
                    Description = "Đầm công chúa phối dạ thu đông kèm nón bánh tiêu cho bé từ 3-8 tuổi",
                    Quantity = 50,
                    Discount = 15,
                    UnitPrice = 200000,
                    Image = "https://cdn.becungshop.vn/images/500x500/dam-cong-chua-thu--dong-kem-ao-choang-long-tho-cho-be-gai-p244141cc00f0e-500x500.jpg"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Đầm công chúa Thu Đông",
                    CategoryId = 2,
                    Description = "Đầm công chúa Thu Đông kèm ào choàng lông thỏ cho bé gái",
                    Quantity = 80,
                    Discount = 15,
                    UnitPrice = 240000,
                    Image = "https://cdn.becungshop.vn/images/500x500/dam-cong-chua-thu--dong-kem-ao-choang-long-tho-cho-be-gai-p244141cc00f0e-500x500.jpg"
                },
                new Product()
                {
                    Id = 6,
                    Name = "Sét jean và áo thun Cá Mập siêu dễ thương",
                    CategoryId = 1,
                    Description = "Sét jean và áo thun Cá Mập siêu dễ thương cho bé trai từ 1-9 tuổi",
                    Quantity = 80,
                    Discount = 15,
                    UnitPrice = 183000,
                    Image = "https://cdn.becungshop.vn/images/500x500/set-jean-va-ao-thun-ca-map-sieu-de-thuong-cho-be-trai-tu-1-9-tuoi-p24410cdcf3549-500x500.jpg"
                },
                new Product()
                {
                    Id = 7,
                    Name = "Bộ thun Hiphop NM AEJY ch bé trai từ 5-10 tuổi",
                    CategoryId = 1,
                    Description = "Bộ thun Hiphop NM AEJY ch bé trai từ 5-10 tuổi",
                    Quantity = 50,
                    Discount = 15,
                    UnitPrice = 190000,
                    Image = "https://cdn.becungshop.vn/images/500x500/bo-thun-hiphop-nm-aejy-ch-be-trai-tu-5-10-tuoi-p244081fc770c8-500x500.jpg"
                },
                new Product()
                {
                    Id = 8,
                    Name = "Bộ bodysuit kèm cà vạt giả vest cho bé trai từ 6 tháng-3 tuổi",
                    CategoryId = 1,
                    Description = "Bộ bodysuit kèm cà vạt giả vest cho bé trai từ 6 tháng-3 tuổi",
                    Quantity = 10,
                    Discount = 20,
                    UnitPrice = 235000,
                    Image = "https://cdn.becungshop.vn/images/500x500/bo-bodysuit-kem-ca-vat-cho-be-trai-tu-6-thang-3-tuoi-p24396aac8739-500x500.jpg"
                },
                new Product()
                {
                    Id = 9,
                    Name = "Bộ tay dài phong cách rock họa tiết LÔNG VŨ cho bé trai từ 7-13 tuổi",
                    CategoryId = 1,
                    Description = "Bộ tay dài phong cách rock họa tiết LÔNG VŨ cho bé trai từ 7-13 tuổi",
                    Quantity = 100,
                    Discount = 10,
                    UnitPrice = 255000,
                    Image = "https://cdn.becungshop.vn/images/500x500/bo-tay-dai-phong-cach-rock-hoa-tiet-long-vu-cho-be-trai-tu-7-13-tuoi-p24383d5ffa941-500x500.jpg"
                },
                new Product()
                {
                    Id = 10,
                    Name = "Sét áo sơ mi và quần yếm kẻ sọc cho bé trai từ 1-4 tuổi",
                    CategoryId = 1,
                    Description = "Sét áo sơ mi và quần yếm kẻ sọc cho bé trai từ 1-4 tuổi",
                    Quantity = 17,
                    Discount = 20,
                    UnitPrice = 25000,
                    Image = "https://cdn.becungshop.vn/images/500x500/set-ao-so-mi-va-quan-yem-ke-soc-cho-be-trai-tu-1-4-tuoi-p2426662256e40-500x500.jpg"
                },
                new Product()
                {
                    Id = 11,
                    Name = "Giày thể thao Spider man cho bé trai",
                    CategoryId = 3,
                    Description = "Giày thể thao Spider man cho bé trai",
                    Quantity = 10,
                    Discount = 10,
                    UnitPrice = 250000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-the-thao-spider-man-cho-be-trai-p242798b7a5d49-500x500.jpg"
                },
                new Product()
                {
                    Id = 12,
                    Name = "Giày thể thao Fashion Classic cho bé trai",
                    CategoryId = 3,
                    Description = "Giày thể thao Fashion Classic cho bé trai",
                    Quantity = 100,
                    Discount = 10,
                    UnitPrice = 330000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-the-thao-fashion-classic-cho-be-trai-p24116b2a706ff-500x500.jpg"
                },
                new Product()
                {
                    Id = 13,
                    Name = "Giày thể thao Fashion Class cho bé gái",
                    CategoryId = 4,
                    Description = "Giày thể thao Fashion Class cho bé gái",
                    Quantity = 130,
                    Discount = 10,
                    UnitPrice = 400000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-the-thao-fashion-class-cho-be-gai-p24117cfa79d91-500x500.jpg"
                },
                new Product()
                {
                    Id = 14,
                    Name = "Giày búp bê gắn nơ kim tuyến cho bé gái từ 3-10 tuổi",
                    CategoryId = 4,
                    Description = "Giày búp bê gắn nơ kim tuyến cho bé gái từ 3-10 tuổi",
                    Quantity = 40,
                    Discount = 15,
                    UnitPrice = 420000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-bup-be-gan-no-kim-tuyen-cho-be-gai-tu-3-10-tuoi-p23776276391e3-500x500.jpg"
                },
                new Product()
                {
                    Id = 15,
                    Name = "Giày thể thao lưới cho bé trai từ 2-10 tuổi",
                    CategoryId = 4,
                    Description = "Giày thể thao lưới cho bé trai từ 2-10 tuổi",
                    Quantity = 50,
                    Discount = 15,
                    UnitPrice = 190000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-the-thao-luoi-cho-be-trai-tu-2-10-tuoi-p23783d2733064-500x500.jpg"
                },
                new Product()
                {
                    Id = 16,
                    Name = "Giày Cross siêu xinh cho bé gái từ 1-5 tuổi",
                    CategoryId = 4,
                    Description = "Giày Cross siêu xinh cho bé gái từ 1-5 tuổi",
                    Quantity = 33,
                    Discount = 15,
                    UnitPrice = 99000,
                    Image = "https://cdn.becungshop.vn/images/500x500/giay-cross-sieu-xinh-cho-be-gai-tu-1-5-tuoi-p2382348e66f05-500x500.jpg"
                },
                new Product()
                {
                    Id = 17,
                    Name = "Nón Snapback Fendi cho bé từ 3-13 tuổi",
                    CategoryId = 5,
                    Description = "Nón Snapback Fendi cho bé từ 3-13 tuổi",
                    Quantity = 6,
                    Discount = 15,
                    UnitPrice = 299000,
                    Image = "https://cdn.becungshop.vn/images/500x500/mu-snapback-fendi-cho-be-tu-3-13-tuoi-p24045dc8d7c1f-500x500.jpg"
                },
                new Product()
                {
                    Id = 18,
                    Name = "Nón Kết Hiphop Cho Bé Trai In Sao Đính Logo Nổi (trên 3 tuổi)",
                    CategoryId = 5,
                    Description = "Nón Kết Hiphop Cho Bé Trai In Sao Đính Logo Nổi (trên 3 tuổi)",
                    Quantity = 43,
                    Discount = 15,
                    UnitPrice = 299000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/65/non-ket-hiphop-cho-be-trai-in-sao-dinh-logo-noi-tren-3-tuoi_(2).JPG?t=1561540048"
                },
                new Product()
                {
                    Id = 19,
                    Name = "Nón tai bèo cho bé gái in sao đính hình gấu ( 2- 4 tuổi)",
                    CategoryId = 5,
                    Description = "Nón tai bèo cho bé gái in sao đính hình gấu ( 2- 4 tuổi)",
                    Quantity = 33,
                    Discount = 15,
                    UnitPrice = 300000,
                    Image = "https://babi.vn/images/watermarked/1/thumbnails/800/800/variant_image/65/non-tai-beo-cho-be-gai-in-sao-dinh-hinh-gau-2-4-tuoi_(4).JPG?t=1561598730"
                },
                new Product()
                {
                    Id = 20,
                    Name = "Nón Kết Cho Bé Gái Trên 3 Tuổi In Hình Công Chúa Dễ Thương",
                    CategoryId = 5,
                    Description = "Nón Kết Cho Bé Gái Trên 3 Tuổi In Hình Công Chúa Dễ Thương",
                    Quantity = 24,
                    Discount = 15,
                    UnitPrice = 320000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/63/non-ket-cho-be-gai-tren-3-tuoi-in-hinh-cong-chua-de-thuong_(4).JPG?t=1553759646"
                },
                new Product()
                {
                    Id = 21,
                    Name = "Balo Mini Cói Đính Hạt Siêu Cưng",
                    CategoryId = 6,
                    Description = "Balo Mini Cói Đính Hạt Siêu Cưng",
                    Quantity = 20,
                    Discount = 15,
                    UnitPrice = 242000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/67/balo-mini-coi-dinh-hat-sieu-cung_(1).jpg?t=1567595383"
                },
                new Product()
                {
                    Id = 22,
                    Name = "Balo in công chúa Elsa cho bé gái ( Trên 3 tuổi )",
                    CategoryId = 6,
                    Description = "Balo in công chúa Elsa cho bé gái ( Trên 3 tuổi )",
                    Quantity = 22,
                    Discount = 15,
                    UnitPrice = 164000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/65/balo-in-cong-chua-elsa-cho-be-gai-tren-3-tuoi_(2).JPG?t=1561349437"
                },
                new Product()
                {
                    Id = 23,
                    Name = "Balo Siêu Nhân Nhện Cho Bé Trai ( Trên 5 tuổi )",
                    CategoryId = 6,
                    Description = "Balo Siêu Nhân Nhện Cho Bé Trai ( Trên 5 tuổi )",
                    Quantity = 34,
                    Discount = 15,
                    UnitPrice = 264000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/65/balo-sieu-nhan-nhen-cho-be-trai-tren-5-tuoi_(1).jpg?t=1561345292"
                },
                new Product()
                {
                    Id = 24,
                    Name = "Balo hoạt hình cho bé từ 2-5 tuổi đi nhà trẻ đi chơi",
                    CategoryId = 6,
                    Description = "Balo hoạt hình cho bé từ 2-5 tuổi đi nhà trẻ đi chơi",
                    Quantity = 30,
                    Discount = 15,
                    UnitPrice = 265000,
                    Image = "https://babi.vn/images/companies/1/Up%20hinh%20san%20pham/101798/balo-hinh-thu-hoa-tiet-hoat-hinh-cho-be%20(9).jpg?1531737011219"
                },
                new Product()
                {
                    Id = 25,
                    Name = "Balo siêu anh hùng cho bé trai",
                    CategoryId = 6,
                    Description = "Balo siêu anh hùng cho bé trai",
                    Quantity = 30,
                    Discount = 15,
                    UnitPrice = 265000,
                    Image = "https://babi.vn/images/watermarked/1/variant_image/53/balo-sieu-anh-hung-cho-be-trai_(2).jpg?t=1534842521"
                });
        }
    }
}
