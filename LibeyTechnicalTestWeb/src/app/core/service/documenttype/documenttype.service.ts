import { DocumentType } from './../../../entities/documenttype';
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../../../environments/environment";

@Injectable({
  providedIn: 'root'
})

export class DocumenttypeService {
	constructor(private http: HttpClient) {}
	
	FindAllDocumentsType(): Observable<DocumentType[]> {
		const uri = `${environment.pathLibeyTechnicalTest}DocumentType`;
		return this.http.get<DocumentType[]>(uri);
	}
}