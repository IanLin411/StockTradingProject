export interface Stock {
    id: number;
    name: string;
    symbol: string;
    price: number;
    change: number;
    volume: number;
}

export interface Category {
    id: number;
    name: string;
    stocks: Stock[];
}