import { Component, ElementRef, HostListener, Input, SimpleChanges, ViewChild } from '@angular/core';

@Component({
  selector: 'app-treemap',
  templateUrl: './treemap.component.html',
  styleUrls: ['./treemap.component.scss']
})
export class TreemapComponent {
  private _treemapData: any[] = [];

  @Input()
  set treemapData(data: any[]) {
    this._treemapData = data;
    this.update();
  }

  get treemapData(): any[] {
    return this._treemapData;
  }

  @ViewChild('treemap', { static: true }) treemapRef!: ElementRef<SVGSVGElement>;
  svgWidth: number = 0;
  svgHeight: number = 0;

  ngOnChanges(changes: SimpleChanges): void {
    this.update()
  }

  @HostListener('window:resize')
  onWindowResize() {
    this.update()
  }
  
  update(){
    const svgElement: SVGSVGElement = this.treemapRef.nativeElement;
    while (svgElement.firstChild) {
      svgElement.removeChild(svgElement.firstChild);
    }

    this.calculateSvgDimensions();
    this.createRectangles(this._treemapData, 0, this.svgWidth, this.svgHeight, 0, 0);
  }

  private calculateSvgDimensions(): void {
    const svgElement: SVGSVGElement = this.treemapRef.nativeElement;
    this.svgWidth = svgElement.getBoundingClientRect().width;
    this.svgHeight = svgElement.getBoundingClientRect().height;
  }

  createRectangles(
    data: any[],
    iteration: number,
    remainingWidth: number,
    remainingHeight: number,
    positionX: number,
    positionY: number
  ): void {
    if (data.length === 0 || remainingWidth <= 0 || remainingHeight <= 0) {
      return;
    }

    data.sort((a, b) => b.value - a.value);
    const sum: number = data.reduce((total, item) => total + item.value, 0);
  
    let rectWidth: number,
      rectHeight: number,
      rectX: number,
      rectY: number,
      posX: number,
      posY: number;
  
    const currentItem = data[0];
    const percentage: number = (currentItem.value / sum) * 100;
  
    if (iteration % 2 === 0) {
      rectWidth = (remainingWidth * percentage) / 100;
      rectHeight = remainingHeight;
      rectX = positionX;
      rectY = positionY;
      posX = positionX + rectWidth;
      posY = positionY;
  
      remainingWidth -= rectWidth;
    } else {
      rectWidth = remainingWidth;
      rectHeight = (remainingHeight * percentage) / 100;
      rectX = positionX;
      rectY = this.svgHeight - remainingHeight;
      posX = positionX;
      posY = positionY + rectHeight;
  
      remainingHeight -= rectHeight;
    }
  
    const rect = document.createElementNS('http://www.w3.org/2000/svg', 'rect');
    rect.setAttribute('x', String(rectX));
    rect.setAttribute('y', String(rectY));
    rect.setAttribute('width', String(rectWidth));
    rect.setAttribute('height', String(rectHeight));
    rect.setAttribute('fill', currentItem.color);
  
    // Create label
    const label = document.createElementNS('http://www.w3.org/2000/svg', 'text');
    label.setAttribute('x', String(rectX + rectWidth / 2));
    label.setAttribute('y', String(rectY + rectHeight / 2));
    label.setAttribute('text-anchor', 'middle');
    label.setAttribute('dominant-baseline', 'middle');
    label.textContent = currentItem.label;
  
    const svgElement: SVGSVGElement = this.treemapRef.nativeElement;
    svgElement.appendChild(rect);
    svgElement.appendChild(label);
  
    this.createRectangles(
      data.slice(1),
      iteration + 1,
      remainingWidth,
      remainingHeight,
      posX,
      posY
    );
  }
  
  
}