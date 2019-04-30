import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient, HttpParams, HttpXsrfTokenExtractor } from '@angular/common/http';
import { NgForm } from '@angular/forms';


export interface Cidade {
  Nome: string;
  Id: number;
  Pais: string;
}

const API = 'http://localhost:50214/trips/';


@Component({
  selector: 'app-cadastro-cidade',
  templateUrl: './cadastro-cidade.component.html',
  styleUrls: ['./cadastro-cidade.component.css']
})

export class CadastroCidadeComponent {  
  
  @Input() cidades: Cidade[];

  constructor(private http: HttpClient) {
    
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

  onSubmit(myform : NgForm) {
    console.log(myform.value);
    this.http.post(API + 'Cidades', myform.value)
    .subscribe(res => { 
      console.log('sucess', res);
      this.ngOnInit();
    }, 
    error => console.log('error', error)
    );
    myform.resetForm();
  }

  onRemove(cidadeId) {    
    this.http.delete(API + 'Cidades/' + cidadeId).subscribe(res => {
      console.log('success', res);
      this.ngOnInit();
    },
    error => console.log('error', error)
    );
  }
  onEdit(myForm: NgForm, cidadeNome, cidadePais) {
    myForm.setValue({Nome: cidadeNome, Pais : cidadePais});
  }

  public AddIcon = require("./plus.svg"); 
  public EditDataIcon = require("./pencil-striped-symbol-for-interface-edit-buttons.svg");
  public RemoveIcon = require ("./garbage.svg"); 
  headElements = ['Cidade', 'País', 'Ações'];

}
