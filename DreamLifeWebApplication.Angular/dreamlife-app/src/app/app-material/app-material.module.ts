import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatToolbarModule } from '@angular/material/toolbar';
import {MatMenuModule} from '@angular/material/menu';
import {MatIconModule} from '@angular/material/icon';
import { MatFormFieldModule, MatSelectModule, MatTableModule } from '@angular/material';

@NgModule({
  imports: [
    CommonModule
  ],
  exports: [
    MatToolbarModule, 
    MatMenuModule,
    MatIconModule,
    MatFormFieldModule,
    MatSelectModule,
    MatTableModule
  ],
  declarations: []
})
export class AppMaterialModule { }
