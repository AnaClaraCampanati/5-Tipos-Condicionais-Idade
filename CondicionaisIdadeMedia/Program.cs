// Elabore um algoritmo que calcule a idade média de 5 alunos.

Console.WriteLine("Digite a idade do primeiro aluno:");
int primeiroAluno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a idade do segundo aluno:");
int segundoAluno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a idade do terceiro aluno:");
int terceiroAluno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a idade do quarto aluno:");
int quartoAluno = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a idade do quinto aluno:");
int quintoAluno = Convert.ToInt32(Console.ReadLine());

int media = (primeiroAluno + segundoAluno + terceiroAluno + quartoAluno + quintoAluno) / 5;

Console.WriteLine("Média: " + media);

