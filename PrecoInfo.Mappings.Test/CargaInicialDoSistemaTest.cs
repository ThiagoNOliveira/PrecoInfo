using NUnit.Framework;
using PrecoInfo.Domain.ComponenteProduto;
using PrecoInfo.InfraStructure.Persistence.UnitOfWorkComponent;
using ProcuraFacil.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Test
{
    [TestFixture]
    public class CargaInicialDoSistemaTest
    {
        [Test]
        public void carregar_os_dados_iniciais()
        {
            IUnitOfWork instance = UnitOfWorkFactory.GetDefault();
            instance.Begin();

            Repositorio<Categoria> categorias = new Repositorio<Categoria>();
            
            Categoria categoria1 = new Categoria { Nome = "Computador", Ordem =1,  NomeImagem = "../Content/ico/cat_computador.png" };

            categoria1.SubCategorias = new List<Categoria>();

            categoria1.SubCategorias.Add(new Categoria { Nome = "Desktops" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Notebook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Netbook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Ultrabook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "iPad/Tablet" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Acessórios Notebook/Netbook" });

            categorias.Adicionar(categoria1);
            
            Categoria categoria2 = new Categoria { Nome = "CPU e memória", Ordem = 2, NomeImagem = "../Content/ico/cat_cpu-memoria.png" };

            categoria2.SubCategorias = new List<Categoria>();

            categoria2.SubCategorias.Add(new Categoria { Nome = "Placas Mãe" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Processadores" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Memórias" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Coolers e Ventiladores" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Acessórios" });

            categorias.Adicionar(categoria2);

            Categoria categoria3 = new Categoria { Nome = "Armazenamento", Ordem =3, NomeImagem = "../Content/ico/cat_armazenamento.png" };

            categoria3.SubCategorias = new List<Categoria>();

            categoria3.SubCategorias.Add(new Categoria { Nome = "Cartões de Memória" });
            categoria3.SubCategorias.Add(new Categoria { Nome = "Discos Rígidos" });
            categoria3.SubCategorias.Add(new Categoria { Nome = "Drives" });
            categoria3.SubCategorias.Add(new Categoria { Nome = "Mídias" });
            categoria3.SubCategorias.Add(new Categoria { Nome = "Pen drives" });

            categorias.Adicionar(categoria3);

            Categoria categoria4 = new Categoria { Nome = "Multimídia", Ordem =4, NomeImagem = "../Content/ico/cat_multimidia.png" };

            categoria4.SubCategorias = new List<Categoria>();

            categoria4.SubCategorias.Add(new Categoria { Nome = "Caixas de Som e Webcam" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Outros" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Placas de Som e Vídeo" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Player MP3, MP4, MP..., Ipod" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Projetores e telas" });

            categorias.Adicionar(categoria4);

            Categoria categoria5 = new Categoria { Nome = "Periféricos", Ordem =5,  NomeImagem = "../Content/ico/cat_perifericos.png" };

            categoria5.SubCategorias = new List<Categoria>();

            categoria5.SubCategorias.Add(new Categoria { Nome = "Impressoras" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Monitores/TVs" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Mouses e Teclados" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Scanners e Mesas Digitalizadoras" });

            categorias.Adicionar(categoria5);

            Categoria categoria6 = new Categoria { Nome = "Suprimentos", Ordem =6, NomeImagem = "../Content/ico/cat_suprimentos.png" };

            categoria6.SubCategorias = new List<Categoria>();

            categoria6.SubCategorias.Add(new Categoria { Nome = "Impressoras" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Monitores/TVs" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Mouses e Teclados" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Scanners e Mesas Digitalizadoras" });

            categorias.Adicionar(categoria6);

            Categoria categoria7 = new Categoria { Nome = "Alimentação", Ordem =7, NomeImagem = "../Content/ico/cat_alimentacao.png" };

            categoria7.SubCategorias = new List<Categoria>();

            categoria7.SubCategorias.Add(new Categoria { Nome = "Estabilizadores" });
            categoria7.SubCategorias.Add(new Categoria { Nome = "Fontes" });
            categoria7.SubCategorias.Add(new Categoria { Nome = "Fontes e Carregadores" });
            categoria7.SubCategorias.Add(new Categoria { Nome = "NoBreaks" });
            categoria7.SubCategorias.Add(new Categoria { Nome = "Pilhas e Baterias" });

            categorias.Adicionar(categoria7);

            Categoria categoria8 = new Categoria { Nome = "Games", Ordem =8, NomeImagem = "../Content/ico/cat_games.png" };

            categoria8.SubCategorias = new List<Categoria>();

            categoria8.SubCategorias.Add(new Categoria { Nome = "Acessórios e Peças" });
            categoria8.SubCategorias.Add(new Categoria { Nome = "Jogos" });
            categoria8.SubCategorias.Add(new Categoria { Nome = "Joysticks e Gamepads" });
            categoria8.SubCategorias.Add(new Categoria { Nome = "Vídeo Games (Consoles)" });
            categoria8.SubCategorias.Add(new Categoria { Nome = "Pilhas e Baterias" });

            categorias.Adicionar(categoria8);

            Categoria categoria9 = new Categoria { Nome = "Eletrônicos", Ordem =9, NomeImagem = "../Content/ico/cat_eletronicos.png" };

            categoria9.SubCategorias = new List<Categoria>();

            categoria9.SubCategorias.Add(new Categoria { Nome = "Acessórios p/ Câmeras Fotográficas" });
            categoria9.SubCategorias.Add(new Categoria { Nome = "Automotivo" });
            categoria9.SubCategorias.Add(new Categoria { Nome = "Câmeras" });
            categoria9.SubCategorias.Add(new Categoria { Nome = "Carregadores para Câmeras" });
            categoria9.SubCategorias.Add(new Categoria { Nome = "GPS / Calculadoras" });

            categorias.Adicionar(categoria9);

            instance.Commit();
        }
    }
}
