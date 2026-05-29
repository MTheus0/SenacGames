using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SenacGames.Domain.Entities;
using SenacGames.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Context
{
    internal class SenacGamesDbContext : IdentityDbContext
    {
        /// <summary>
        /// Construtor da classe SenacGamesDbContext, que recebe as opções de configuração do DbContext e as passa para a classe base.
        /// </summary>
        public SenacGamesDbContext(DbContextOptions<SenacGamesDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// DbSet para a entidade Game, representando a tabela de jogos no banco de dados.
        /// </summary>
        public DbSet<Game> Games { get; set; }

        /// <summary>
        /// DbSet para a entidade Category, representando a tabela de categorias no banco de dados.
        /// </summary>
        public DbSet<Category> Categories { get; set; }


        /// <summary>
        /// Configura o modelo de dados para a aplicação, aplicando as configurações específicas para as entidades.
        /// </summary>
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new GameConfiguration());
        }
    }
}
