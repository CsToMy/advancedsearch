import { Injectable } from "@angular/core";
import { Product } from "./product.model";
import { RestDataSource } from "./rest.datasource";
@Injectable()
export class ProductRepository {
    public products: Product[] = [];
    public categories: string[] = [];
    
    constructor(private dataSource: RestDataSource) {
        
        dataSource.getProducts().subscribe(data => {
            this.products = data;
        });

        dataSource.getCategories().subscribe(data => {
            this.categories = data.sort();
        });
    }

    getProducts(category: string|null): Product[] {
        this.dataSource.getProducts().subscribe(data => {
            this.products = data;
            return this.products.filter(p => category == null || category == p.category);
        }, 
        error => {
            console.log("Hiba történt. "+ JSON.stringify(error));
            return [];
        });

        return [];
    }

    getProduct(id: number): Product | undefined {
        return this.products.find(prod => prod.id == id);
    }

    getCategories(): string[] {
        return this.categories;
    }
}