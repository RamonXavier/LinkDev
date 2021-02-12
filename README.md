## LinkDev

# Como Executar:
O sistema é feito em .Net Framework e poderá ser executado a partir do Visal Studio (V.2017 +).
O banco de dados do sistema é utilizado pelo próprio visual studio (SQL Server Express LocalDB).

1 - Após abrir o projeto em seu visual studio, acesse seu SQL Server Expresss e pegue o nome do seu 
servidor local:	
	- Menu View -> SQL Server Object Explorer;
	
	- Expanda -> SQL Server -> (LocalDB) e clique com o botão direito em LOcalDB e escolha 'Propriedades';
	- Na lista a direita que é apresentada, role para cima até a 1ª opção e copie um trecho parecido com este
	na opção Connection String: "(LocalDB)\MSSQLLocalDB";
	
	- Abra o arquivo Web.config do projeto e encontre a string de conexão com o banco de dados e substitua o 
	seguinte trecho: "(LocalDb)\V11.0" pelo que você encontrou no passo anterior.

2 - Após fazer este procedimento, abra o Pack Manager Console e digite o comando: "Update-Database -Verbose" (sem aspas).
Este comando irá rodar as migrations do projeto e criar sua base.

# Objetivo:
O Objetivo deste projeto é criar um sistema web para divulgação de curriculos de profissionais de diversas áreas
e também para postagens, tutoriais e meu portfólio.


# Tecnologias:
Para desenvolvimento da plataforma foram utilizados algumas tecnologias: 

Para front-end: 
	Html5,
	Css,
  Razor,
  Bootstrap,
  UiKit,
  JavaScritp;
  
  Para Backend:
  SQL Server Express LocalDB,
  C#,
  .Net Framework,
  Entity Framework,
  Linq.

# Ferramentas:
	-Para edição de texto e a programação em si foi utilizada a IDE Visual Studio; 
 

# Contato: 
	Ramon Xavier
	 Ramon438xavier@gmail.com
	 (32) 99137-5797
	 www.linkedin.com/in/ramonxavier
