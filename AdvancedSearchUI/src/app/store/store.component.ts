import { Component } from "@angular/core";
import { Product } from "../models/product.model";
import { ProductRepository } from "../models/product.repository";
import { Cart } from "../models/cart.model";
import { Router } from "@angular/router";

@Component({
 selector: "store",
 templateUrl: "store.component.html"
})
export class StoreComponent {
    public selectedCategory: string|null = null;
    productsPerPage: number = 3;
    currentPage: number = 1;

    constructor(private repository: ProductRepository, 
                private cart: Cart,
                private router: Router) { }
    
    get products(): Product[] {
        let pageIndex = (this.currentPage - 1) * this.productsPerPage;
        return this.repository.getProducts(this.selectedCategory)
            .slice(pageIndex, pageIndex + this.productsPerPage);
    }
 
    get categories(): string[] {
        return this.repository.getCategories();
    }

    changeCategory(newCategory: string | null): void {
        this.selectedCategory = newCategory;
    }

    changePage(newPage: number) {
        this.currentPage = newPage;
    }

    changePageSize(event:any) {
        this.productsPerPage = Number(event.target.value);
        this.changePage(1);
    }
        
    get pageNumbers(): number[] {
        return Array(Math.ceil(this.repository
            .getProducts(this.selectedCategory).length / this.productsPerPage))
            .fill(0).map((x, i) => i + 1);
    }

    addProductToCart(product: Product): void{
        this.cart.addLine(product);
        this.router.navigateByUrl("/cart");
    }
}