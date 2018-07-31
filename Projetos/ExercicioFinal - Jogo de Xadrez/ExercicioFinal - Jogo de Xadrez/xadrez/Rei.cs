using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            if (validaPosicoes(posicao.linha - 1, posicao.coluna, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //ne
            if (validaPosicoes(posicao.linha - 1, posicao.coluna + 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //so
            if (validaPosicoes(posicao.linha - 1, posicao.coluna - 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            if (validaPosicoes(posicao.linha, posicao.coluna + 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //esquerda
            if (validaPosicoes(posicao.linha, posicao.coluna - 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            if (validaPosicoes(posicao.linha + 1, posicao.coluna, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo so
            if (validaPosicoes(posicao.linha + 1, posicao.coluna - 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo se
            if (validaPosicoes(posicao.linha + 1, posicao.coluna + 1, pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            return mat;

        }

        private bool validaPosicoes(int lin, int col, Posicao pos)
        {

            pos.definirValores(lin, col);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
