import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { observable, Observable } from "rxjs";
import { getBaseUrl } from "../../../main";
import { Aluno } from "../../modelo/aluno";


@Injectable({
  providedIn: "root"
})
export class AlunoServico {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  private verificarAluno(Aluno: Aluno): Observable<Aluno> {

    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      nome: Aluno.nome
    }

    return this.http.post<Aluno>(this.baseURL + "api/Aluno", body, { headers });

  }

}
