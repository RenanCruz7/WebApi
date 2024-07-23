using Microsoft.EntityFrameworkCore;

/*
 * Com DbContext, podemos criar um contexto de banco de dados para o Entity Framework Core.
 * o que facilita a conexão com o banco de dados e a manipulação de dados.
 * então toda vez que quisermos acessar o banco de dados, podemos usar o contexto.
 * 
 * Lembrando que para fazer isso preciso instalar o pacote do Entity Framework Core. 
 * e o pacote do MySql para o Entity Framework Core.
 * 
 **/


namespace WebApiDemo.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {
        }
        public DbSet<Models.Post> Posts { get; set; }
    }
}
