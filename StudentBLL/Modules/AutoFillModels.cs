using AutoMapper;
using StudentBLL.ViewModel;
using StudentDAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentBLL.Services
{
   public class AutoFillModels:Profile
    {
        public AutoFillModels()
        {
            CreateMap<StudentModel, StudentViewModel>().ReverseMap();
        }
    }
}
