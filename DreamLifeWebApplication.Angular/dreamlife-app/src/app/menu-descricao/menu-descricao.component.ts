import { Component, Input, EventEmitter, Output } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { FormControl } from "@angular/forms";


export interface Cidade {
  Nome: string;
  Id: number;
  Pais: string;
}

//const API = 'http://localhost:50214/trips/';
const API = 'http://localhost/DreamLifeWeb_api/trips/';


@Component({
  selector: 'menu-descricao',
  templateUrl: './menu-descricao.component.html',
  styleUrls: ['./menu-descricao.component.css']
})

export class MenuDescricaoComponent {

  @Input() cidades: Cidade[];
  

  public PlaceHolderIcon = require("./img/placeholder.svg");
  public CalendarIcon = require("./img/calendar-page-empty.svg");
  public ManUserIcon = require("./img/man-user.svg");
  public CrownIcon = require("./img/crown.svg");
  public CreditCardIcon = require("./img/credit-card.svg");
  public flag: boolean;

  date = new FormControl(new Date());
  selectedValue: string;

  @Output() messageEvent = new EventEmitter<string>();
  
  constructor(private http: HttpClient) { }
  
  sendMessage() {
    this.messageEvent.emit(this.selectedValue);
  }

  ngOnInit() {
    this.flag = true;
    this.getCidades()
      .subscribe(cidades => {
        this.cidades = cidades;
        console.log(this.cidades);
      });
  }

  getCidades() {
    //let params = new HttpParams().set('CidadeId', '1');
    return this.http
      .get<Cidade[]>(API + 'Cidades');
  }
}
