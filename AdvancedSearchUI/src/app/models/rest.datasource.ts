import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Product } from "./product.model";
import { Order } from "./order.model";
import { environment } from "src/environments/environment";

const PROTOCOL = "http";
const PORT = 3500;

@Injectable()
export class RestDataSource {
 
    baseUrl: string;
    httpHeader: any;
 
    constructor(private http: HttpClient) {
        this.baseUrl = `${PROTOCOL}://${location.hostname}:${PORT}/`;
        this.baseUrl = environment.baseUrl;
    }

    getProducts(categoryFilter?: string): Observable<Product[]> {
        let url : string = (categoryFilter === undefined || categoryFilter === null)? 
        this.baseUrl + 'Product/getProducts' :
        this.baseUrl + 'Product/getProducts/' + categoryFilter;

        return this.http.get<Product[]>(url);
    }

    searchProducts(productFilter: any): Observable<Product[]> {
        return this.http.post<Product[]>(environment.baseUrl+'Product/searchProduct', productFilter);
    }
    
    saveOrder(order: Order): Observable<Order> {
        return this.http.post<Order>(this.baseUrl + 'Order/saveOrder', order);
    }

    getCategories(): Observable<string[]> {
        return this.http.get<string[]>(this.baseUrl + 'Product/getCategories');
    }
}