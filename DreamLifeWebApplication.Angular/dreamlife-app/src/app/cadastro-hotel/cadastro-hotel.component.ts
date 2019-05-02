import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NgbRatingConfig } from '@ng-bootstrap/ng-bootstrap';
import { NgForm, FormGroup, FormControl } from '@angular/forms';


export interface Cidade {
  Nome: string;
  Id: number;
  Pais: string;
}

//const API = 'http://localhost:50214/trips/';
const API = 'http://localhost/DreamLifeWeb_api/trips/';


@Component({
  selector: 'app-cadastro-hotel',
  templateUrl: './cadastro-hotel.component.html',
  styleUrls: ['./cadastro-hotel.component.css'],
})

export class CadastroHotelComponent implements OnInit {

  @Input() cidades: Cidade[];

  selectedValue: number;
  currentRate = 0;
  formConcluido: boolean = false;

  myform = new FormGroup( {
    Nome: new FormControl(),
    Localizacao: new FormControl(),
    Preco: new FormControl(),
    Classificacao: new FormControl(),
    Descricao: new FormControl(),
    CidadeId: new FormControl()
  });


  constructor(private http: HttpClient, config: NgbRatingConfig) {
    config.max = 5;
    config.readonly = false;
   }

  ngOnInit() {
    this.getCidades()
      .subscribe(cidades => {
        this.cidades = cidades
        console.log(this.cidades)
      });
  }

  getCidades(){
    //let params = new HttpParams().set('CidadeId', '1');
    return this.http
    .get<Cidade[]>(API + 'Cidades');        
}

onConcluir(){
  this.formConcluido = true;
  this.myform.value.CidadeId  = this.selectedValue;
  console.log(this.myform.value);
  this.http.post(API + 'Hotels', this.myform.value)
  .subscribe(res => { 
    console.log('sucess', res);},
    error => console.log('error', error)
    );
    
  this.myform.reset();
  this.selectedValue = undefined;
}

limparForm(){
  this.myform.reset();
}

  public PlaceHolderIcon = require("./placeholder.svg"); 
  public GarbageIcon = require("./garbage.svg");
  
}
