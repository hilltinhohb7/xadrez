﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qteMovimentos, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qteMovimentos = qteMovimentos;
            this.tab = tab;
        }
    }
}
