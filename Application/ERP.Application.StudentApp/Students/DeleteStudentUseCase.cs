using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.Application.StudentApp.Students;

namespace ERP.Application.StudentApp.Students
{
    public class DeleteStudentUseCase : IDeleteStudentUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task ExecuteAsync(Student student)
        {
            await _studentRepository.DeleteStudentAsync(student);
        }


    }
}