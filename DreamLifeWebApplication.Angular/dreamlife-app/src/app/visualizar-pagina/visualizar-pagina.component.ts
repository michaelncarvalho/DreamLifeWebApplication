import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export interface Hotel {
  Nome: string;
  CidadeId: number;
  Preco: number;
  Classificacao: number;
  Descricao: string;
  Localizacao: string;
  Cidade: any;
}

//const API = 'http://localhost:50214/trips/';
const API = 'http://localhost/DreamLifeWeb_api/trips/';

@Component({
  selector: 'app-visualizar-pagina',
  templateUrl: './visualizar-pagina.component.html',
  styleUrls: ['./visualizar-pagina.component.css']
})
export class VisualizarPaginaComponent implements OnInit {

  @Input() hoteis: Hotel[];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getHoteis()
    .subscribe(hoteis => {
      this.hoteis = hoteis;
      console.log(this.hoteis);
    })
  }

  getHoteis(){
    return this.http
    .get<Hotel[]>(API + 'Hotels'); 
  }

  onDelete(hotelId: number){
    this.http.delete(API + 'Hotels/DeleteHotel/' + hotelId)
    .subscribe(res => {
      console.log('sucess,', res);
      this.ngOnInit();
    },
    error => console.log('error', error));
  }

  public EditDataIcon = require("./pencil-striped-symbol-for-interface-edit-buttons.svg");
  public RemoveIcon = require ("./garbage.svg"); 
  headElements = ['HOTEIS CADASTRADOS', 'CIDADE', 'AÇÕES'];
}
