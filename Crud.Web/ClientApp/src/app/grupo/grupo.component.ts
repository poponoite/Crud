import { Component } from "@angular/core"
@Component({
  selector: "app-grupo",
  template: "<html><body><h1>Página de grupo</></body></html>"
})
export class GrupoComponent {
  public nome: string;

  public getNome(): string {
    return this.nome;
  }
}
