import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http"
import { Observable } from "rxjs";
import { Aluno } from "../../modelo/aluno";


@Injectable({
  providedIn: "root"
})
export class ProvaServico {

  private _baseURL: string;
  private alunosClassificados: Aluno[];

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseURL = baseUrl;
  }

  ngOnInit(): void {
    this.alunosClassificados = [];
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json');
  }

  public verificarAlunosClassificados() {
    return this.http.get<Aluno[]>(this._baseURL + "api/Prova/GetClassificados");
  }
  
/*
 * Observable<Aluno>: fica aguardando mudança de status da Action e espera um Aluno como retorno
 * http.post<Aluno>: executa o verbo POST e retorna um aluno vencedor
 * JSON.stringify(this.alunosClassificados): Monta um Json com os 5 alunos classificados e envia pelo Post
 */
  public definirCampeao(alunos: Aluno[]): Observable<Aluno> {
    return this.http.post<Aluno>(this._baseURL + "api/Prova/DefinirCampeao", JSON.stringify(alunos), { headers: this.headers });
  }

}
