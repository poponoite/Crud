import { Component} from "@angular/core"

@Component({
  selector: "app-usuario",
  template: "<html><body>{{ obterNome() }}</body></html>"
})
export class UsuarioComponent {

 public nome: string;
 public descricao: string;
  grupo: string;

  obterNome(): string {
    return "Teste em typescript na classe Usuario";
  }
}
