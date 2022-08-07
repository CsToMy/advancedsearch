import { Injectable } from "@angular/core";
import { ArgumentOutOfRangeError } from "rxjs";
import { Product } from "./product.model";
import { StaticDataSource } from "./static.datasource";

@Injectable()
export class ProductRepository {
    private products: Product[] = [];
    private categories: string[] = [];
    
    constructor(private dataSource: StaticDataSource) {
        dataSource.getProducts().subscribe(data => {
            this.products = data;
            this.categories = data.map<string>(p => p.category)
            .filter((c, index, array) => array.indexOf(c) == index)
            .sort();
        });
    }

    getProducts(category: string|null): Product[] {
        return this.products.filter(p => category == null || category == p.category);
    }

    getProduct(id: number): Product | undefined {
        return this.products.find(prod => prod.id == id);
    }

    getCategories(): string[] {
        return this.categories;
    }
}