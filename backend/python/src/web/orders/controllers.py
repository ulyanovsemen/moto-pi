from fastapi import APIRouter
from .models import Order

router = APIRouter(
    prefix="/orders",
    tags=["orders"]
)


@router.post("/")
async def create_order(order: Order):
    return {"id": "1", "name": f"{order.name}"}
