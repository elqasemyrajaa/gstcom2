import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes } from '@angular/router';
import { PaiementComponent } from './paiement/paiement.component';
const routes: Routes = [ 
    {path: 'paiement', component: PaiementComponent}
  ];
@NgModule({
    declarations: [
    ],
    
    imports: [
        CommonModule
    ],
    providers: [
      
    ],
    
  })
export class PaimentRouting {
}
