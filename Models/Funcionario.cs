using System.ComponentModel.DataAnnotations;
namespace webapi.Models
{
    public class Funcionario
    {
        [Key]
        public int idfuncionario { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string departamento { get; set; }
        public string admissao { get; set; }
        public int salario { get; set; }
        public string cargo { get; set; }
        public int idregiao { get; set; }    

        
    }
}


// +---------------+--------------+------+-----+---------+-------+
// | Field         | Type         | Null | Key | Default | Extra |
// +---------------+--------------+------+-----+---------+-------+
// | idFuncionario | int          | YES  |     | NULL    |       |
// | nome          | varchar(100) | YES  |     | NULL    |       |
// | email         | varchar(200) | YES  |     | NULL    |       |
// | sexo          | varchar(10)  | YES  |     | NULL    |       |
// | departamento  | varchar(100) | YES  |     | NULL    |       |
// | admissao      | varchar(10)  | YES  |     | NULL    |       |
// | salario       | int          | YES  |     | NULL    |       |
// | cargo         | varchar(100) | YES  |     | NULL    |       |
// | idRegiao      | int          | YES  |     | NULL    |       |
// +---------------+--------------+------+-----+---------+-------+
