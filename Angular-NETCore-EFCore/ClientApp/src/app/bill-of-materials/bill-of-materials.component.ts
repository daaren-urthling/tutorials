import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

interface BOMData {
  bom: string;
  description: string;
}

@Component({
  selector: 'app-bill-of-materials',
  templateUrl: './bill-of-materials.component.html',
  styleUrls: ['./bill-of-materials.component.css']
})
export class BillOfMaterialsComponent implements OnInit {

  public BOMCode: string;
  public bom: BOMData;

  constructor(public http: HttpClient, @Inject('BASE_URL') public baseUrl: string) { }

  ngOnInit() { }

  onShowBOM() {
    this.http.get<BOMData[]>(`${this.baseUrl}billofmaterials/bom?bom=${this.BOMCode}`).subscribe(result => {
      this.bom = result[0];
    }, error => console.error(error));    
  }
}

