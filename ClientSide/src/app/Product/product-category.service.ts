import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { ProductCategory } from './product-category';

@Injectable({
  providedIn: 'root'
})
export class ProductCategoryService {
url="http://144.91.76.98:5000/api/ProductCategories";
  constructor(private http:HttpClient) { }
  /******************Get Products Category********************* */
  getProduct(){
    return this.http.get<ProductCategory[]>(this.url);
  }
  /********************Post Product Category********************************* */
  AddProductCategory(pro:ProductCategory) {
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      name: pro.name, remarque: pro.remarque,   id: pro.id
    }
    return this.http.post<ProductCategory>(this.url, body, { headers })
  }
  /****************** ***Edit Product Category*******************/   
  EditProductCategory(pro:ProductCategory) {
    console.log("pro id : ",pro.id);
    const params = new HttpParams().set('id',pro.id);
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      name: pro.name,remarque:pro.remarque,id:pro.id
    }
    return this.http.put<ProductCategory>(this.url+'/' + pro.id, body, {headers,params})
  }
  /*********************************Delete Product Category************************************** */
  delete(id){
    return this.http.delete(this.url+'/'+id);
  }
}
