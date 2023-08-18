namespace FirstCoreMVCWebApp.Models;

public interface IStudentRepository
{
	Student GetStudentById(int StudentId);
}