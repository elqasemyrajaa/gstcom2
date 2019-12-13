import { Component, OnInit, Input, EventEmitter, Output, ViewChild, ElementRef } from '@angular/core';
import { StatutService } from 'src/app/DataService/statut.service';
import { StautService } from '../staut.service';
import { NgForm } from '@angular/forms';
import { Statut } from 'src/Models/statut.model';





@Component({
  selector: 'app-statut',
  templateUrl: './statut.component.html',
  styleUrls: ['./statut.component.sass']
})
export class StatutComponent implements OnInit {

constructor(private dataservce:StautService){

}
@Output() nameEvent = new EventEmitter<string>();
@ViewChild('closeBtn', { static: false, }) cb: ElementRef;
  ngOnInit() {

    this.LoadData();

  }
  dataavailbale:boolean=false;
  tempdate:Statut;
  objlist:Statut[];
  
  
  LoadData(){
    this.dataservce.getStatuts().subscribe((tempdate) => {
      this.objlist = tempdate;
        console.log(this.objlist);
        if (this.objlist.length > 0) {
          this.dataavailbale = true;
          console.log("data existe");
        }
        else {
          this.dataavailbale = false;
        }
      }
      )
        , err => {
          console.log(err);
        }
  }
  objtempemp:Statut;
  @Input() objemp: Statut = new Statut();
  @Input() IsNew: boolean = true;
  
  AddStatut(regForm: NgForm) {
      this.objtempemp=new Statut();      
      this.objtempemp.libelle=regForm.value.libelle;
      this.objtempemp.remarque=regForm.value.remarque;    
      this.dataservce.AddStatut(this.objtempemp).subscribe(res=>{
        alert("Statut Added successfully");
        this.LoadData();

      })

    
  }

  deleteStatut(id){
    this.dataservce.delete(id).subscribe(res=>{
      alert('suppression bien fait');
      this.LoadData();
    })
  }
  

}
