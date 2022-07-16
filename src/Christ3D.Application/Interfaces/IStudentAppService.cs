using Christ3D.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Application.Interfaces
{
    public interface IStudentAppService
    {
        IEnumerable<StudentViewModel> GetAll();
        StudentViewModel GetById(Guid id);
        void Register(StudentViewModel StudentViewModel);

        void Update(StudentViewModel StudentViewModel);
        void Remove(Guid id);


    }
}
