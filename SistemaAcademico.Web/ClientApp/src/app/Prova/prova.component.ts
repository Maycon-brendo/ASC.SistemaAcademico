import { Component, Inject } from '@angular/core';
import { Aluno } from '../modelo/aluno';
import { ProvaServico } from '../servicos/Prova/prova.servico';
import { Router } from '@angular/router';
import { interval, Subscription } from 'rxjs';

@Component({
  selector: 'app-prova',
  templateUrl: 'prova.component.html'
})

//export class ProvaComponent {

//  public id: number;
//  public nome: string;

//  public obterNome(): string {
//    return "A1";
//  }
//}

export class EventoComponent {
  public alunosClassificados: Aluno[];
  private aluno: Aluno;
  private updateSubscription: Subscription;
  public txtFiltrar: string;

  constructor(private provaServico: ProvaServico, private router: Router) {
    
  }

  ngOnInit(): void {
    this.alunosClassificados = [];
    this.aluno = new Aluno();    
  }

  public simularCampeao() {
    this.provaServico.definirCampeao(this.alunosClassificados)
      .subscribe(
        alunoCampeaoJson => {
          //Exibe log se obteve sucesso
          console.log(alunoCampeaoJson);
        },
        error => {
          console.log(error);
        }
      );
  }

  public buscarClassificados() {
    this.provaServico.verificarAlunosClassificados()
      .subscribe(
        provasJson => {
          //Exibe log se obteve sucesso
          this.alunosClassificados = provasJson;
        },
        error => {
          console.log(error);
        }
      );
  }
}
