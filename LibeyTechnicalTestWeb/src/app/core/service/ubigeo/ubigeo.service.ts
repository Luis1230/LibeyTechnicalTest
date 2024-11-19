import { Region } from './../../../entities/region';
import { Provincia } from './../../../entities/provincia';
import { Ubigeo } from './../../../entities/ubigeo';
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class UbigeoService {
	constructor(private http: HttpClient) {}
	
	FindAllRegion(): Observable<Region[]> {
		const uri = `${environment.pathLibeyTechnicalTest}Ubigeo/region`;
		return this.http.get<Region[]>(uri);
	}

	FindAllProvince(regionCode: string): Observable<Provincia[]> {
		const uri = `${environment.pathLibeyTechnicalTest}Ubigeo/province/${regionCode}`;
		return this.http.get<Provincia[]>(uri);
	}

	FindAllUbigeo(provinciaCode: string): Observable<Ubigeo[]> {
		const uri = `${environment.pathLibeyTechnicalTest}Ubigeo/ubigeo/${provinciaCode}`;
		return this.http.get<Ubigeo[]>(uri);
	}
}
