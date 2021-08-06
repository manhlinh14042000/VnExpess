using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VnExpress.Data.Entities;

namespace VnExpress.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   CategoryId = 1,
                   CategoryName = "Văn hóa",
                   Description = "Mo ta"

               },
               new Category()
               {
                   CategoryId = 2,
                   CategoryName = "Xã hội",
                   Description = "Mo ta"
                   

               },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Kinh tế",
                    Description = "Mo ta"
                });
            modelBuilder.Entity<Post>().HasData(
               new Post()
               {
                   Id = 1,
                   Title = "Tình hình kinh tế thế giới",
                   Author = "Hoàng Nam",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Tình hình kinh tế châu á",
                   MainContent = "Tình hình kinh tế EU",
                   Images = "Ảnh",
                   CategoryId = 1,

               }, new Post()
               {
                   Id = 2,
                   Title = "Phân công nhiệm vụ chống dịch của bốn phó thủ tướng",
                   Author = "Từ trái sang: Các Phó thủ tướng Phạm Bình Minh, Lê Minh Khái, Vũ Đức Đam, Lê Văn Thành. Ảnh: Tạ Lư",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Ngày 5/8, Thủ tướng phân công nhiệm vụ của bốn phó thủ tướng, các bộ trưởng, trưởng ngành, chủ tịch UBND cấp tỉnh trong công tác phòng chống Covid-19.",
                   MainContent = "Phó thủ tướng Lê Minh Khái xử lý các vấn đề liên quan đến chính sách tài chính, thuế, bảo hiểm, lãi suất ngân hàng, cơ chế mua sắm, giá dịch vụ thiết yếu, các khoản hỗ trợ đối với doanh nghiệp, người dân, đặc biệt là người lao động xa quê, mất việc làm tại địa bàn thực hiện giãn cách xã hội, phong tỏa, cách ly.",
                   Images = "https://i1-vnexpress.vnecdn.net/2021/08/05/z2620997921162-b4efe02c49d4ce4-3044-6402-1628165019.jpg?w=680&h=0&q=100&dpr=1&fit=crop&s=riWdaDPG5m3C40lXPmpaZA",
                   CategoryId = 2,

               },
               new Post()
               {
                   Id = 3,
                   Title = "Tình hình văn hóa thế giới",
                   Author = "Văn Trung",
                   DateCreated = DateTime.Now.Date,
                   ShortContent = "Tình hình văn hóa châu á",
                   MainContent = "Tình hình văn hóa EU",
                   Images = "Ảnh",
                   CategoryId = 3,

               });
            modelBuilder.Entity<User>().HasData(
               new User()
               {
                  IdUser = 1,
                  FirstName = "Tuấn",
                  LastName = "Anh",
                  Email = "anh453138@gmail.com",
                  UserName = "tuananh",
                  Password = "123456",
                  ConfirmPassword = "123456",

               }, new User()
               {
                   IdUser = 2,
                   FirstName = "Ad",
                   LastName = "min",
                   Email = "admin453138@gmail.com",
                   UserName = "admin",
                   Password = "123456",
                   ConfirmPassword = "123456",
               });
        }
    }
}
