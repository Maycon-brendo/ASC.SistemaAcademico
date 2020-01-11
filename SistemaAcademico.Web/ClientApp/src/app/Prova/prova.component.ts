import { Component } from "@angular/core"

@Component({
  selector: "app-prova",
  template: "<html><body>{{ obterNome() }}</body></html>"
})

export class ProvaComponent {

  public id: number;
  public nome: string;

  public obterNome(): string {
    return "A1";
  }
}
