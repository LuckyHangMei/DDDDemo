using AutoMapper;
using Christ3D.Application.ViewModels;
using Christ3D.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Application
{
    /// <summary>
    /// 平时我们写AutoMapper映射实体关系类
    /// </summary>
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Student, StudentViewModel>().ReverseMap();
        }
    }
}
