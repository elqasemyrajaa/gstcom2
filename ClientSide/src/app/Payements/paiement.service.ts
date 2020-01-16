import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Paiement } from 'src/Models/paiement';

@Injectable({
  providedIn: 'root'
})
export class PaiementService {

  url:string="http://192.168.0.220:42333/api/payments";
  constructor(private http:HttpClient ) { }
    /*********************get Payments********************** */
    getPayments() {
      return this.http.get<Paiement[]>(this.url);
    }
}
